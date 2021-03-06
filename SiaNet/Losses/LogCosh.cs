﻿using System;
using System.Collections.Generic;
using System.Text;
using TensorSharp;

namespace SiaNet.Losses
{
    public class LogCosh : BaseLoss
    {
        public LogCosh()
            : base("logcosh")
        {

        }

        public override Tensor Call(Tensor preds, Tensor labels)
        {
            return Mean(_logcosh(preds - labels), -1);
        }

        private Tensor _logcosh(Tensor x)
        {
            return x + Softplus(-2 * x) - (float)Math.Log(2);
        }

        public override Tensor CalcGrad(Tensor preds, Tensor labels)
        {
            return -1 * Tanh(labels - preds) / preds.Shape[0];
        }
    }
}
