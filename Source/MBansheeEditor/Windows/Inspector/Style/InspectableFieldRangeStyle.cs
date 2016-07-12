﻿//********************************** Banshee Engine (www.banshee3d.com) **************************************************//
//**************** Copyright (c) 2016 Marko Pintera (marko.pintera@gmail.com). All rights reserved. **********************//

namespace BansheeEditor
{
    /// <summary>
    /// Contains info about the range of values a field can store
    /// </summary>
    public sealed class InspectableFieldRangeStyle : InspectableFieldStyle
    {
        public InspectableFieldRangeStyle(float min, float max, float step = 0.0f)
        {
            this.Max = max;
            this.Min = min;
            this.Step = step;
        }

        /// <summary>
        /// The maximum value the field can be assigned
        /// </summary>
        public float Max { get; set; }
        /// <summary>
        /// The minimum value the field can be assigned
        /// </summary>
        public float Min { get; set; }

        public float Step { get; set; }
    }
}
