﻿using System;
using System.Collections.Generic;
using System.Text;
using SiaNet.Losses;
using TensorSharp;

namespace SiaNet.Metrics
{
    public class MSLE : BaseMetric
    {
        public MSLE()
            :base("msle")
        {

        }

        public override Tensor Call(Tensor preds, Tensor labels)
        {
            return new MeanSquaredLogError().Call(preds, labels);
        }
    }
}
