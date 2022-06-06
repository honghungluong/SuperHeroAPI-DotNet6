using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Interfaces;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnemyController : ControllerBase
    {
        private readonly IEnemyRepository _EnemyRepository;

        public EnemyController(IEnemyRepository EnemyRepository)
        {
            _EnemyRepository = EnemyRepository;
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(Enemy enemy)
        {
            var _enemy = await _EnemyRepository.CreateAsync(enemy);

            return Ok(_enemy);
        }
    }
}
