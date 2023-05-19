#if !DOTNETCORE
using System.Net;

namespace Elasticsearch.Net7
{
	/// <summary> The default IConnection implementation. Uses <see cref="HttpWebRequest" /> on the current .NET desktop framework.</summary>
	public class HttpConnection : HttpWebRequestConnection { }
}
#endif
