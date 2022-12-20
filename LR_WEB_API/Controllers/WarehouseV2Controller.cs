using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LR_WEB_API.Controllers
{
    [Route("api/warehouse")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v2")]
    public class WarehouseV2Controller : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public WarehouseV2Controller(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetWarehouse()
        {
            var warehouse = await
           _repository.Warehouse.GetAllWarehouseAsync(trackChanges:
            false);
            return Ok(warehouse);
        }
    }
}