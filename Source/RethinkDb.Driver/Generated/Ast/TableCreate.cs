








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;

namespace RethinkDb.Driver.Ast {
    public class TableCreate : ReqlQuery {
    
    
        public TableCreate (object arg) : this(new Arguments(arg), null) {
        }
        public TableCreate (Arguments args, OptArgs optargs) : this(null, args, optargs) {
        }
        public TableCreate (ReqlAst prev, Arguments args, OptArgs optargs)
             : this(prev, TermType.TABLE_CREATE, args, optargs) {
        }

    protected TableCreate (ReqlAst previous, TermType termType, Arguments args, OptArgs optargs) : base(previous, termType, args, optargs)
    {
    }


    

    /* Static Factories */

        public static TableCreate FromArgs(params object[] args){
         return new TableCreate (new Arguments(args), null);
        }


    

    


    
    }
}
