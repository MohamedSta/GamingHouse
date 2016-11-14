using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gaming.data.Models;

namespace gaming.service
{
   public class NewsService: Service<news>, INewsService
    {
    }
}
