








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class ImplicitVar : ReqlQuery {
    
    
        public ImplicitVar (object arg) : this(new Arguments(arg), null) {
        }
        public ImplicitVar (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public ImplicitVar (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.IMPLICIT_VAR, args, optargs) {
        }

    protected ImplicitVar (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static ImplicitVar FromArgs(params object[] args){
         return new ImplicitVar (new Arguments(args), null);
        }


    

    


    
    }
}
