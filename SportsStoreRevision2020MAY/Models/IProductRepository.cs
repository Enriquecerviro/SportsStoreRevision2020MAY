using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStoreRevision2020MAY.Models
{
    /// <summary>
    /// Necesitamos una manera de recojer Productos de la db, para ello definiremos una interfaz IQueryable para obtener una secuencia d eProcutos
    /// 
    /// </summary>
    public class IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
