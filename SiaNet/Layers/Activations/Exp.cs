﻿using System;
using System.Collections.Generic;
using System.Text;
using TensorSharp;
using TensorSharp.Expression;

namespace SiaNet.Layers.Activations
{
    public class Exp : BaseLayer
    {
        public Exp()
            : base("exp")
        {
        }

        public override void Forward(Variable x)
        {
            Input = x;
            Output = Exp(x.Data);
        }

        public override void Backward(Tensor outputgrad)
        {
            Input.Grad = Mul(outputgrad, Output);
        }
    }
}
