using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoder.Models;
using WebApiCoder.Repository;

namespace MiPrimeraAppV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {


        [HttpGet("{idUsuario}")]
        public List<Producto> GetSaleProductByUserId(long idUsuario)
        {
            
            return ManejadorProductoVendido.ObtenerProductoVendido(idUsuario);
        }

    }

}

