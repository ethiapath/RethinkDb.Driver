








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Limit : ReqlQuery {
    
    
        public Limit (object arg) : this(new Arguments(arg), null) {
        }
        public Limit (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Limit (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.LIMIT, args, optargs) {
        }

    protected Limit (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Limit FromArgs(params object[] args){
         return new Limit (new Arguments(args), null);
        }


    

    


    
    }
}
