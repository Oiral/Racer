// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:1,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33374,y:32737,varname:node_4013,prsc:2|diff-1447-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:3973,x:32348,y:32908,varname:node_3973,prsc:2;n:type:ShaderForge.SFN_Append,id:5993,x:32621,y:32773,varname:node_5993,prsc:2|A-3973-Y,B-3973-Z;n:type:ShaderForge.SFN_NormalVector,id:1486,x:32451,y:32599,prsc:2,pt:False;n:type:ShaderForge.SFN_Abs,id:4591,x:32621,y:32599,varname:node_4591,prsc:2|IN-1486-OUT;n:type:ShaderForge.SFN_Multiply,id:5517,x:32803,y:32599,varname:node_5517,prsc:2|A-4591-OUT,B-4591-OUT;n:type:ShaderForge.SFN_Append,id:6676,x:32621,y:32949,varname:node_6676,prsc:2|A-3973-Z,B-3973-X;n:type:ShaderForge.SFN_Append,id:491,x:32621,y:33125,varname:node_491,prsc:2|A-3973-X,B-3973-Y;n:type:ShaderForge.SFN_Tex2d,id:5340,x:32805,y:33125,ptovrint:False,ptlb:XY texture,ptin:_XYtexture,varname:node_5340,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5302278195dca44468a5e3b05cb33243,ntxv:0,isnm:False|UVIN-491-OUT;n:type:ShaderForge.SFN_Tex2d,id:2353,x:32805,y:32949,ptovrint:False,ptlb:XZ texture,ptin:_XZtexture,varname:_node_5340_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5302278195dca44468a5e3b05cb33243,ntxv:0,isnm:False|UVIN-6676-OUT;n:type:ShaderForge.SFN_Tex2d,id:1419,x:32805,y:32773,ptovrint:False,ptlb:YZ texture,ptin:_YZtexture,varname:_node_5340_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:5302278195dca44468a5e3b05cb33243,ntxv:0,isnm:False|UVIN-5993-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:560,x:32987,y:32841,varname:node_560,prsc:2,chbt:0|M-5517-OUT,R-1419-RGB,G-2353-RGB,B-5340-RGB;n:type:ShaderForge.SFN_Color,id:6788,x:32987,y:33011,ptovrint:False,ptlb:node_6788,ptin:_node_6788,varname:node_6788,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1911765,c2:0.1911765,c3:0.1911765,c4:1;n:type:ShaderForge.SFN_Lerp,id:1447,x:33210,y:32841,varname:node_1447,prsc:2|A-560-OUT,B-6788-RGB,T-5553-OUT;n:type:ShaderForge.SFN_Slider,id:5553,x:32963,y:33191,ptovrint:False,ptlb:node_5553,ptin:_node_5553,varname:node_5553,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;proporder:5340-2353-1419-6788-5553;pass:END;sub:END;*/

Shader "Shader Forge/Testing Shader" {
    Properties {
        _XYtexture ("XY texture", 2D) = "white" {}
        _XZtexture ("XZ texture", 2D) = "white" {}
        _YZtexture ("YZ texture", 2D) = "white" {}
        _node_6788 ("node_6788", Color) = (0.1911765,0.1911765,0.1911765,1)
        _node_5553 ("node_5553", Range(0, 1)) = 0
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _XYtexture; uniform float4 _XYtexture_ST;
            uniform sampler2D _XZtexture; uniform float4 _XZtexture_ST;
            uniform sampler2D _YZtexture; uniform float4 _YZtexture_ST;
            uniform float4 _node_6788;
            uniform float _node_5553;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 node_4591 = abs(i.normalDir);
                float3 node_5517 = (node_4591*node_4591);
                float2 node_5993 = float2(i.posWorld.g,i.posWorld.b);
                float4 _YZtexture_var = tex2D(_YZtexture,TRANSFORM_TEX(node_5993, _YZtexture));
                float2 node_6676 = float2(i.posWorld.b,i.posWorld.r);
                float4 _XZtexture_var = tex2D(_XZtexture,TRANSFORM_TEX(node_6676, _XZtexture));
                float2 node_491 = float2(i.posWorld.r,i.posWorld.g);
                float4 _XYtexture_var = tex2D(_XYtexture,TRANSFORM_TEX(node_491, _XYtexture));
                float3 node_560 = (node_5517.r*_YZtexture_var.rgb + node_5517.g*_XZtexture_var.rgb + node_5517.b*_XYtexture_var.rgb);
                float3 diffuseColor = lerp(node_560,_node_6788.rgb,_node_5553);
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _LightColor0;
            uniform sampler2D _XYtexture; uniform float4 _XYtexture_ST;
            uniform sampler2D _XZtexture; uniform float4 _XZtexture_ST;
            uniform sampler2D _YZtexture; uniform float4 _YZtexture_ST;
            uniform float4 _node_6788;
            uniform float _node_5553;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                LIGHTING_COORDS(2,3)
                UNITY_FOG_COORDS(4)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
/////// Diffuse:
                float NdotL = max(0.0,dot( normalDirection, lightDirection ));
                float3 directDiffuse = max( 0.0, NdotL) * attenColor;
                float3 node_4591 = abs(i.normalDir);
                float3 node_5517 = (node_4591*node_4591);
                float2 node_5993 = float2(i.posWorld.g,i.posWorld.b);
                float4 _YZtexture_var = tex2D(_YZtexture,TRANSFORM_TEX(node_5993, _YZtexture));
                float2 node_6676 = float2(i.posWorld.b,i.posWorld.r);
                float4 _XZtexture_var = tex2D(_XZtexture,TRANSFORM_TEX(node_6676, _XZtexture));
                float2 node_491 = float2(i.posWorld.r,i.posWorld.g);
                float4 _XYtexture_var = tex2D(_XYtexture,TRANSFORM_TEX(node_491, _XYtexture));
                float3 node_560 = (node_5517.r*_YZtexture_var.rgb + node_5517.g*_XZtexture_var.rgb + node_5517.b*_XYtexture_var.rgb);
                float3 diffuseColor = lerp(node_560,_node_6788.rgb,_node_5553);
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
