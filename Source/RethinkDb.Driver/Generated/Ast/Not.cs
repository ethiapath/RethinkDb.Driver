








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Not : ReqlQuery {
    
    
        public Not (object arg) : this(new Arguments(arg), null) {
        }
        public Not (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Not (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.NOT, args, optargs) {
        }

    protected Not (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Not FromArgs(params object[] args){
         return new Not (new Arguments(args), null);
        }


    

    


    
    }
}
