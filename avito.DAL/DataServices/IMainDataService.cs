using System.Threading;
using System.Threading.Tasks;
using avito.DAL.DataObjects;

namespace avito.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

