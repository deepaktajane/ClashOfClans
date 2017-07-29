using System;
using System.Collections.Generic;

namespace ClashOfClans
{
    public class Fleet
    {
        private readonly IEnumerable<ITroop> _troopers;
        
        public Fleet(IEnumerable<ITroop> troopers)
        {
            _troopers = troopers;
        }

        public void Attack()
        {
            foreach(var troop in _troopers)
            {
                troop.Attack();
            }
        }
    }
}