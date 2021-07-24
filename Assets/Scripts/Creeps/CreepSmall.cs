﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Creeps
{
    class CreepSmall : CreepBase
    {
        void LateUpdate()
        {
            Move(Speed);
        }
        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Attacked(float Demage)
        {
            base.Attacked(Demage);
        }

        public override void Move(float Speed)
        {
            base.Move(Speed);
        }

        public override int OnDeath()
        {
            throw new NotImplementedException();
        }
    }
}
