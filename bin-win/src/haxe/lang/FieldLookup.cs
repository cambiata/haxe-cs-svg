
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldLookup {
		
		#pragma warning disable 628
		static FieldLookup() {
			#line 35 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			global::haxe.lang.FieldLookup.length = ( global::haxe.lang.FieldLookup.fieldIds as global::System.Array ).Length;
		}
		#line default
		
		public FieldLookup() {
		}
		
		
		protected static int[] fieldIds = new int[]{105, 4745537, 4849249, 5393365, 5442204, 5594513, 76061764, 87367608, 302979532, 328878574, 359333139, 407283053, 452737314, 501039929, 520590566, 946786476, 1067353468, 1103412149, 1181037546, 1204816148, 1224901875, 1247875546, 1280845662, 1282943179, 1352786672, 1532710347, 1547539107, 1620824029, 1621420777, 1623148745, 1648581351, 1705629508, 1781145963, 1830310359, 1915412854, 1916009602, 1981972957, 2025055113, 2082663554, 2084789794, 2127021138};
		
		protected static string[] fields = new string[]{"i", "__a", "arr", "len", "map", "pop", "remove", "filter", "methodName", "iterator", "lastIndexOf", "hasNext", "reverse", "insert", "length", "toString", "splice", "copy", "join", "concat", "next", "push", "sort", "quicksort", "spliceVoid", "concatNative", "className", "__unsafe_get", "__unsafe_set", "indexOf", "fileName", "toDynamic", "__hx_constructs", "customParams", "__get", "__set", "lineNumber", "unshift", "shift", "__hx_createEmpty", "slice"};
		
		protected static int length;
		
		public static void addFields(int[] nids, string[] nfields) {
			#line 41 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			int[] cids = global::haxe.lang.FieldLookup.fieldIds;
			string[] cfields = global::haxe.lang.FieldLookup.fields;
			int nlen = ( nids as global::System.Array ).Length;
			int clen = global::haxe.lang.FieldLookup.length;
			if (( ( nfields as global::System.Array ).Length != nlen )) {
				#line 45 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Different fields length: ", global::haxe.lang.Runtime.toString(nlen)), " and "), global::haxe.lang.Runtime.toString(( nfields as global::System.Array ).Length)));
			}
			
			#line 48 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			bool needsChange = false;
			{
				#line 49 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int[] _g_arr = nids;
				#line 49 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				uint _g_idx = ((uint) (0) );
				#line 49 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (((bool) (( _g_idx < ( _g_arr as global::System.Array ).Length )) )) {
					#line 49 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int i = ((int) (_g_arr[((int) (_g_idx++) )]) );
					#line 51 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( global::haxe.lang.FieldLookup.findHash(i, cids, clen) < 0 )) {
						#line 53 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						needsChange = true;
						break;
					}
					
				}
				
			}
			
			#line 59 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
			if (needsChange) {
				#line 61 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				lock(typeof(global::haxe.lang.FieldLookup)){
					#line 63 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int[] ansIds = new int[( clen + nlen )];
					string[] ansFields = new string[( clen + nlen )];
					int ci = 0;
					#line 65 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int ni = 0;
					#line 65 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int ansi = 0;
					while (( ( ci < clen ) && ( ni < nlen ) )) {
						#line 68 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						if (( cids[ci] < nids[ni] )) {
							#line 70 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							ansIds[ansi] = cids[ci];
							ansFields[ansi] = cfields[ci];
							 ++ ci;
						}
						else {
							#line 74 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							ansIds[ansi] = nids[ni];
							ansFields[ansi] = nfields[ni];
							 ++ ni;
						}
						
						#line 78 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						 ++ ansi;
					}
					
					#line 81 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( ci < clen )) {
						#line 83 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (cids) ), ((int) (ci) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
						global::System.Array.Copy(((global::System.Array) (cfields) ), ((int) (ci) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
						ansi += ( clen - ci );
					}
					
					#line 88 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( ni < nlen )) {
						#line 90 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (nids) ), ((int) (ni) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
						global::System.Array.Copy(((global::System.Array) (nfields) ), ((int) (ni) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
						ansi += ( nlen - ni );
					}
					
					#line 96 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::haxe.lang.FieldLookup.fieldIds = ansIds;
					global::haxe.lang.FieldLookup.fields = ansFields;
					global::haxe.lang.FieldLookup.length = ansi;
				}
				;
			}
			
		}
		#line default
		
		public static int doHash(string s) {
			unchecked {
				#line 106 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int acc = 0;
				{
					#line 107 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int _g1 = 0;
					#line 107 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int _g = s.Length;
					#line 107 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					while (( _g1 < _g )) {
						#line 107 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int i = _g1++;
						#line 109 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
					}
					
				}
				
				#line 112 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
			#line default
		}
		
		
		public static string lookupHash(int key) {
			unchecked {
				#line 118 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = global::haxe.lang.FieldLookup.length;
				#line 122 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (( min < max )) {
					#line 124 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int mid = ( min + ((int) (( (( max - min )) / 2 )) ) );
					int imid = ids[mid];
					if (( key < imid )) {
						#line 128 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						max = mid;
					}
					else if (( key > imid )) {
						#line 130 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 132 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return global::haxe.lang.FieldLookup.fields[mid];
					}
					
				}
				
				#line 136 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)));
			}
			#line default
		}
		
		
		public static int hash(string s) {
			unchecked {
				#line 141 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				if (string.Equals(s, null)) {
					#line 141 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					return 0;
				}
				
				#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int key = default(int);
				#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				{
					#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int acc = 0;
					#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					{
						#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int _g1 = 0;
						#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						int _g = s.Length;
						#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						while (( _g1 < _g )) {
							#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							int i = _g1++;
							#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
						}
						
					}
					
					#line 143 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					key = ((int) (( ((uint) (acc) ) >> 1 )) );
				}
				
				#line 146 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				string[] fld = global::haxe.lang.FieldLookup.fields;
				int min = 0;
				int max = global::haxe.lang.FieldLookup.length;
				#line 151 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int len = global::haxe.lang.FieldLookup.length;
				#line 153 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (( min < max )) {
					#line 155 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) {
						#line 159 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						max = mid;
					}
					else if (( key > imid )) {
						#line 161 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 163 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						string field = fld[mid];
						if ( ! (string.Equals(field, s)) ) {
							#line 165 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
							return  ~ (key) ;
						}
						
						#line 166 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return key;
					}
					
				}
				
				#line 172 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				lock(typeof(global::haxe.lang.FieldLookup)){
					#line 173 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( len != global::haxe.lang.FieldLookup.length )) {
						#line 174 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return global::haxe.lang.FieldLookup.hash(s);
					}
					
					#line 180 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::haxe.lang.FieldLookup.insert<int>(ref global::haxe.lang.FieldLookup.fieldIds, global::haxe.lang.FieldLookup.length, min, key);
					global::haxe.lang.FieldLookup.insert<string>(ref global::haxe.lang.FieldLookup.fields, global::haxe.lang.FieldLookup.length, min, s);
					#line 185 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					 ++ global::haxe.lang.FieldLookup.length;
				}
				;
				#line 187 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return key;
			}
			#line default
		}
		
		
		public static int findHash(int hash, int[] hashs, int length) {
			unchecked {
				#line 192 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int min = 0;
				int max = length;
				#line 195 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				while (( min < max )) {
					#line 197 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					int mid = ((int) (( (( max + min )) / 2 )) );
					int imid = hashs[mid];
					if (( hash < imid )) {
						#line 201 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						max = mid;
					}
					else if (( hash > imid )) {
						#line 203 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						min = ( mid + 1 );
					}
					else {
						#line 205 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						return mid;
					}
					
				}
				
				#line 209 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				return  ~ (min) ;
			}
			#line default
		}
		
		
		public static void @remove<T>(T[] a, int length, int pos) {
			unchecked {
				#line 215 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = default(T);
			}
			#line default
		}
		
		
		public static void insert<T>(ref T[] a, int length, int pos, T x) {
			unchecked {
				#line 221 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				int capacity = ( a as global::System.Array ).Length;
				if (( pos == length )) {
					#line 224 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 226 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						T[] newarr = new T[( (( length << 1 )) + 1 )];
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						a = ((T[]) (newarr) );
					}
					
				}
				else if (( pos == 0 )) {
					#line 233 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					if (( capacity == length )) {
						#line 235 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						T[] newarr1 = new T[( (( length << 1 )) + 1 )];
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						a = ((T[]) (newarr1) );
					}
					else {
						#line 241 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					#line 248 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					T[] newarr2 = new T[( (( length << 1 )) + 1 )];
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					a = ((T[]) (newarr2) );
				}
				else {
					#line 255 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				#line 259 "F:\\node-haxe\\test\\node_modules\\haxe\\std\\cs\\internal\\FieldLookup.hx"
				a[pos] = x;
			}
			#line default
		}
		
		
	}
}


