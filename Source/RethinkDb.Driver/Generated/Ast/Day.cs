








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class Day : ReqlQuery {
    
    
        public Day (object arg) : this(new Arguments(arg), null) {
        }
        public Day (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public Day (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.DAY, args, optargs) {
        }

    protected Day (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static Day FromArgs(params object[] args){
         return new Day (new Arguments(args), null);
        }


    

    


    
    }
}
