
#pragma warning disable 109, 114, 219, 429, 168, 162
public class Std {
	
	public Std() {
	}
	
	
	public static bool @is(object v, object t) {
		#line 29 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		if (( v == null )) {
			#line 30 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
			return global::haxe.lang.Runtime.eq(t, typeof(object));
		}
		
		#line 31 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		if (( t == null )) {
			#line 32 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
			return false;
		}
		
		#line 33 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		global::System.Type clt = ((global::System.Type) (t) );
		if (global::haxe.lang.Runtime.typeEq(clt, null)) {
			#line 35 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
			return false;
		}
		
		#line 36 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		string name = global::haxe.lang.Runtime.toString(clt);
		#line 38 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		switch (name) {
			case "System.Double":
			{
				#line 41 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
				return v is double || v is int;
			}
			
			
			case "System.Int32":
			{
				#line 43 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
				return haxe.lang.Runtime.isInt(v);
			}
			
			
			case "System.Boolean":
			{
				#line 45 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
				return v is bool;
			}
			
			
			case "System.Object":
			{
				#line 47 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
				return true;
			}
			
			
		}
		
		#line 50 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		return clt.IsAssignableFrom(((global::System.Type) (global::cs.Lib.getNativeType(v)) ));
	}
	#line default
	
	public static string @string(object s) {
		#line 54 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		if (( s == null )) {
			#line 55 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
			return "null";
		}
		
		#line 56 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		if (( s is bool )) {
			#line 57 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
			if (global::haxe.lang.Runtime.toBool(s)) {
				#line 57 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
				return "true";
			}
			else {
				#line 57 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
				return "false";
			}
			
		}
		
		#line 59 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\_std\\Std.hx"
		return s.ToString();
	}
	#line default
	
}


