﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExtender.Ast
{
    public class TypeExpression : Expression
    {
        /// <summary>
        /// Initalizes a new instance of the <see cref="TypeExpression"/> class.
        /// </summary>
        /// <param name="type">Target type</param>
        internal TypeExpression(Type type)
        {
            this.type = type;
        }

        /// <summary>
        /// Gets the underlying type.
        /// </summary>
        public TypeReference Type
        {
            get
            {
                return new TypeReference(this.type);
            }
        }

        public override CodeType CodeType
        {
            get { return CodeType.TypeExpression; }
        }

        private Type type;
   
    }
}
