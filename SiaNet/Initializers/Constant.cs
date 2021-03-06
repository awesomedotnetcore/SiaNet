﻿using System;
using System.Collections.Generic;
using System.Text;
using TensorSharp;
using TensorSharp.Expression;

namespace SiaNet.Initializers
{
    public class Constant : BaseInitializer
    {
        public float Value { get; set; }

        public Constant(float value)
            :base("constant")
        {
            Value = value;
        }

        internal Constant(string name, float value)
           : base(name)
        {
            Value = value;
        }

        public override Tensor Operator(params long[] shape)
        {
            Tensor tensor = new Tensor(Global.Device, DType.Float32, shape);
            Ops.Fill(tensor, Value);
            return tensor;
        }
    }
}
