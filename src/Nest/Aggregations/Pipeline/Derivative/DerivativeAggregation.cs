// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elasticsearch.Net7.Utf8Json;

namespace Nest7
{
	[InterfaceDataContract]
	[ReadAs(typeof(DerivativeAggregation))]
	public interface IDerivativeAggregation : IPipelineAggregation { }

	public class DerivativeAggregation : PipelineAggregationBase, IDerivativeAggregation
	{
		internal DerivativeAggregation() { }

		public DerivativeAggregation(string name, SingleBucketsPath bucketsPath)
			: base(name, bucketsPath) { }

		internal override void WrapInContainer(AggregationContainer c) => c.Derivative = this;
	}

	public class DerivativeAggregationDescriptor
		: PipelineAggregationDescriptorBase<DerivativeAggregationDescriptor, IDerivativeAggregation, SingleBucketsPath>
			, IDerivativeAggregation { }
}
