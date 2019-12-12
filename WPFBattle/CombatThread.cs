using OhioState.RoleplayingGameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPFBattle
{

    //private Variable variable;


    class CombatThread
    {
        private ICombat encounter;

        public CombatThread(ICombat combat)
        {
            this.encounter = combat;
        }


        private Thread thread;

        public void Start()
        {
            thread = new System.Threading.Thread(() => //give this code
            {
                encounter.AutoBattle();
            });
            thread.Name = "GameThread";
            thread.Start();
        }
        public void Deactivate()
        {
            thread.Abort();


        }
    }
}
