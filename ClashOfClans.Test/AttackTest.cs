using Xunit;

namespace ClashOfClans.Test
{
    public class AttackTest
    {
        [Fact]
        public void IfAttackedByOneCannonAndOneBarbarian_ThenDefenceShouldWin()
        {
            var fleet = new Fleet(new ITroop[]{ new Cannon(), new Barbarian() });

            fleet.Attack();
        }
    }
}
