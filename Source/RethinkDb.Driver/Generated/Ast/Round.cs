








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Round : ReqlQuery {
    
    
        public Round (object arg) : this(new Arguments(arg), null) {
        }
        public Round (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Round (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.ROUND, args, optargs) {
        }

    protected Round (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Round FromArgs(params object[] args){
         return new Round (new Arguments(args), null);
        }


    

    


    
    }
}
