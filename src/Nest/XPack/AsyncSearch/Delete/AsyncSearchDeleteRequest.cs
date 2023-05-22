using System.Collections.Generic;

namespace Nest7
{
	[MapsApi("async_search.delete.json")]
	[ReadAs(typeof(AsyncSearchDeleteRequest))]
	public partial interface IAsyncSearchDeleteRequest { }

	/// <inheritdoc cref="IAsyncSearchDeleteRequest"/>
	public partial class AsyncSearchDeleteRequest
	{
	}

	/// <inheritdoc cref="IAsyncSearchDeleteRequest"/>
	public partial class AsyncSearchDeleteDescriptor
	{
	}
}
