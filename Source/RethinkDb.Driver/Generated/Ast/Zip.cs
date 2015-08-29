








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Zip : ReqlQuery {
    
    
        public Zip (object arg) : this(new Arguments(arg), null) {
        }
        public Zip (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Zip (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.ZIP, args, optargs) {
        }

    protected Zip (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Zip FromArgs(params object[] args){
         return new Zip (new Arguments(args), null);
        }


    

    


    
    }
}
