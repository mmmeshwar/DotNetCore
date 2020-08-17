using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetCodeAPI.Models;

namespace DotNetCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderMasterController : ControllerBase
    {
        private readonly MagnaRJR20072020Context _context;

        public OrderMasterController(MagnaRJR20072020Context context)
        {
            _context = context;
        }

        // GET: api/OrderMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KttuOrderMaster>>> GetKttuOrderMaster()
        {
            return await _context.KttuOrderMaster.ToListAsync();
        }

        // GET: api/OrderMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KttuOrderMaster>> GetKttuOrderMaster(string id)
        {
            var kttuOrderMaster = await _context.KttuOrderMaster.FindAsync(id);

            if (kttuOrderMaster == null)
            {
                return NotFound();
            }

            return kttuOrderMaster;
        }

        // PUT: api/OrderMaster/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKttuOrderMaster(string id, KttuOrderMaster kttuOrderMaster)
        {
            if (id != kttuOrderMaster.ObjId)
            {
                return BadRequest();
            }

            _context.Entry(kttuOrderMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KttuOrderMasterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderMaster
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<KttuOrderMaster>> PostKttuOrderMaster(KttuOrderMaster kttuOrderMaster)
        {
            _context.KttuOrderMaster.Add(kttuOrderMaster);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (KttuOrderMasterExists(kttuOrderMaster.ObjId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetKttuOrderMaster", new { id = kttuOrderMaster.ObjId }, kttuOrderMaster);
        }

        // DELETE: api/OrderMaster/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<KttuOrderMaster>> DeleteKttuOrderMaster(string id)
        {
            var kttuOrderMaster = await _context.KttuOrderMaster.FindAsync(id);
            if (kttuOrderMaster == null)
            {
                return NotFound();
            }

            _context.KttuOrderMaster.Remove(kttuOrderMaster);
            await _context.SaveChangesAsync();

            return kttuOrderMaster;
        }

        private bool KttuOrderMasterExists(string id)
        {
            return _context.KttuOrderMaster.Any(e => e.ObjId == id);
        }
    }
}
