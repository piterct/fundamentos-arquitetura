﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._02___OCP.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}
