








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Var : ReqlQuery {
    
    
        public Var (object arg) : this(new Arguments(arg), null) {
        }
        public Var (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Var (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.VAR, args, optargs) {
        }

    protected Var (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Var FromArgs(params object[] args){
         return new Var (new Arguments(args), null);
        }


    

    


    
    }
}
