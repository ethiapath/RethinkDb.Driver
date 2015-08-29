








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Friday : ReqlQuery {
    
    
        public Friday (object arg) : this(new Arguments(arg), null) {
        }
        public Friday (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Friday (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.FRIDAY, args, optargs) {
        }

    protected Friday (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Friday FromArgs(params object[] args){
         return new Friday (new Arguments(args), null);
        }


    

    


    
    }
}
