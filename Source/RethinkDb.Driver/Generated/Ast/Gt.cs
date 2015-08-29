








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Gt : ReqlQuery {
    
    
        public Gt (object arg) : this(new Arguments(arg), null) {
        }
        public Gt (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Gt (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.GT, args, optargs) {
        }

    protected Gt (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Gt FromArgs(params object[] args){
         return new Gt (new Arguments(args), null);
        }


    

    


    
    }
}
