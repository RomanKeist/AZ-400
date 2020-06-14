using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Vouchers.Api
{
    [Route("api/[controller]")]
    public class VoucherDetailsController : Controller
    {
        private readonly VouchersDBContext ctx;

        public VoucherDetailsController(VouchersDBContext context)
        {
            ctx = context;
        }

        [HttpGet]
        public IEnumerable<VoucherDetail> Get()
        {
            var vds = ctx.VoucherDetails.Include(v => v.Account).ToList();
            return vds;
        }

        [HttpGet("{id}")]
        public VoucherDetail Get(int id)
        {
            return ctx.VoucherDetails.Include(v => v.Account).FirstOrDefault(v => v.ID == id);
        }

        [HttpPost]
        public void Post([FromBody] VoucherDetail value)
        {
            ctx.VoucherDetails.Add(value);
            ctx.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VoucherDetail value)
        {
            var v = Get(id);
            if (v != null)
            {
                Mapper.CopyData(value, v);
                ctx.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var v = Get(id);
            if (v != null)
            {
                ctx.Remove(v);
                ctx.SaveChanges();
            }
        }
    }
}