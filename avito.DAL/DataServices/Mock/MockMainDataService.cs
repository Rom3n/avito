using System.Threading;
using System.Threading.Tasks;
using avito.DAL.DataObjects;

namespace avito.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("avito.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

