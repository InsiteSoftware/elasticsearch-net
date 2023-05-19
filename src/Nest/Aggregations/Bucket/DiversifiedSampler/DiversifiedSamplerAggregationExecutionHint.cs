using System.Runtime.Serialization;
using Elasticsearch.Net7;

namespace Nest7
{
	[StringEnum]
	public enum DiversifiedSamplerAggregationExecutionHint
	{
		[EnumMember(Value = "map")]
		Map,

		[EnumMember(Value = "global_ordinals")]
		GlobalOrdinals,

		[EnumMember(Value = "bytes_hash")]
		BytesHash
	}
}
