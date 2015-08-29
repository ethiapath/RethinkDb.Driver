








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class June : ReqlQuery {
    
    
        public June (object arg) : this(new Arguments(arg), null) {
        }
        public June (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public June (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.JUNE, args, optargs) {
        }

    protected June (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static June FromArgs(params object[] args){
         return new June (new Arguments(args), null);
        }


    

    


    
    }
}
