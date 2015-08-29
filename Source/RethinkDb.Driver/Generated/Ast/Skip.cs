








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Skip : ReqlQuery {
    
    
        public Skip (object arg) : this(new Arguments(arg), null) {
        }
        public Skip (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Skip (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.SKIP, args, optargs) {
        }

    protected Skip (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Skip FromArgs(params object[] args){
         return new Skip (new Arguments(args), null);
        }


    

    


    
    }
}
