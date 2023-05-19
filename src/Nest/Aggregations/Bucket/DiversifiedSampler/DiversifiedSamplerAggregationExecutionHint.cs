using System.Runtime.Serialization;
using Elasticsearch.Net;

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
