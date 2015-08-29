








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Minutes : ReqlQuery {
    
    
        public Minutes (object arg) : this(new Arguments(arg), null) {
        }
        public Minutes (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Minutes (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.MINUTES, args, optargs) {
        }

    protected Minutes (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Minutes FromArgs(params object[] args){
         return new Minutes (new Arguments(args), null);
        }


    

    


    
    }
}
