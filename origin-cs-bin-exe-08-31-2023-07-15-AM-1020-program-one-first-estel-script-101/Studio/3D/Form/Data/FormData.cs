﻿using Core;

namespace Core
{
    using System;

    public partial struct FormData
    {
        public FormMeasure Measure;

        public ControlFlowSchedule ControlFlowSchedule;

        public FormBase FormBase;

        public FormLine FormLine;

        public Int32[] PositionArray;

        public Boolean IsDebug;
    }
}
