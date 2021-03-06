﻿using System;
using System.Collections.Generic;
using System.Text;
using TensorSharp;
using TensorSharp.Expression;

namespace SiaNet.Layers
{
    public class Flatten : BaseLayer
    {
        public Flatten()
             : base("flatten")
        {

        }

        public override void Forward(Variable x)
        {
            Input = x;

            Output = x.Data.View(1, x.Data.ElementCount());
        }

        public override void Backward(Tensor outputgrad)
        {
        }
    }
}
