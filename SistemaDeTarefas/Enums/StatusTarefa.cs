﻿using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFazer = 1,
        [Description("EmAndamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido =3

    }
}
