// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:1,spxs:False,tesm:0,olmd:0,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:4013,x:33059,y:32706,varname:node_4013,prsc:2|diff-3082-OUT,spec-111-OUT,gloss-9367-OUT,normal-4965-OUT,emission-3082-OUT,olwid-3276-OUT,olcol-3235-RGB;n:type:ShaderForge.SFN_FragmentPosition,id:4762,x:32103,y:33633,varname:node_4762,prsc:2;n:type:ShaderForge.SFN_ViewPosition,id:6994,x:32103,y:33508,varname:node_6994,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3276,x:32469,y:33669,varname:node_3276,prsc:2|A-7574-OUT,B-9345-OUT;n:type:ShaderForge.SFN_Slider,id:9345,x:32187,y:33831,ptovrint:False,ptlb:Outline Width,ptin:_OutlineWidth,varname:_OutlineWidth,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01282051,max:0.5;n:type:ShaderForge.SFN_Distance,id:7574,x:32304,y:33573,varname:node_7574,prsc:2|A-6994-XYZ,B-4762-XYZ;n:type:ShaderForge.SFN_Color,id:3235,x:32622,y:33634,ptovrint:False,ptlb:Outline Color,ptin:_OutlineColor,varname:_OutlineColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_NormalVector,id:9768,x:31610,y:32792,prsc:2,pt:False;n:type:ShaderForge.SFN_Abs,id:3116,x:31772,y:32792,varname:node_3116,prsc:2|IN-9768-OUT;n:type:ShaderForge.SFN_Multiply,id:8885,x:31941,y:32792,varname:node_8885,prsc:2|A-3116-OUT,B-3116-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:1845,x:31753,y:32491,varname:node_1845,prsc:2;n:type:ShaderForge.SFN_Append,id:7826,x:31938,y:32342,varname:node_7826,prsc:2|A-1845-Y,B-1845-Z;n:type:ShaderForge.SFN_Append,id:1830,x:31938,y:32657,varname:node_1830,prsc:2|A-1845-X,B-1845-Y;n:type:ShaderForge.SFN_Append,id:9709,x:31938,y:32491,varname:node_9709,prsc:2|A-1845-X,B-1845-Z;n:type:ShaderForge.SFN_Tex2d,id:1704,x:32402,y:32000,ptovrint:False,ptlb:Texture 1,ptin:_Texture1,varname:_Texture1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7826-OUT;n:type:ShaderForge.SFN_Tex2d,id:2504,x:32402,y:32227,ptovrint:False,ptlb:Texture 2,ptin:_Texture2,varname:_Texture2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9709-OUT;n:type:ShaderForge.SFN_Tex2d,id:3521,x:32402,y:32464,ptovrint:False,ptlb:Texture 3,ptin:_Texture3,varname:_Texture3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1830-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:3082,x:32610,y:32238,cmnt:Tileable World Space Textures,varname:node_3082,prsc:2,chbt:0|M-8885-OUT,R-1704-RGB,G-2504-RGB,B-3521-RGB;n:type:ShaderForge.SFN_ChannelBlend,id:111,x:32638,y:32626,varname:node_111,prsc:2,chbt:0|M-8885-OUT,R-9184-R,G-8763-R,B-2021-R;n:type:ShaderForge.SFN_Tex2d,id:8763,x:32201,y:32632,ptovrint:False,ptlb:Metallic 2,ptin:_Metallic2,varname:_Metallic2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9709-OUT;n:type:ShaderForge.SFN_Tex2d,id:2021,x:32201,y:32868,ptovrint:False,ptlb:Metallic 3,ptin:_Metallic3,varname:_Metallic3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7826-OUT;n:type:ShaderForge.SFN_Tex2d,id:9184,x:32201,y:32413,ptovrint:False,ptlb:Metallic 1,ptin:_Metallic1,varname:_Metallic1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1830-OUT;n:type:ShaderForge.SFN_Tex2d,id:5019,x:32399,y:33379,ptovrint:False,ptlb:Normal 3,ptin:_Normal3,varname:_Normal3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1830-OUT;n:type:ShaderForge.SFN_Tex2d,id:4742,x:32399,y:33154,ptovrint:False,ptlb:Normal 2,ptin:_Normal2,varname:_Normal2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-9709-OUT;n:type:ShaderForge.SFN_Tex2d,id:6048,x:32399,y:32927,ptovrint:False,ptlb:Normal 1,ptin:_Normal1,varname:_Normal1,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7826-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:4965,x:32636,y:33154,varname:node_4965,prsc:2,chbt:0|M-8885-OUT,R-6048-RGB,G-4742-RGB,B-5019-RGB;n:type:ShaderForge.SFN_ChannelBlend,id:9367,x:32638,y:32773,varname:node_9367,prsc:2,chbt:0|M-8885-OUT,R-9184-A,G-8763-A,B-2021-A;proporder:9345-3235-6048-4742-5019-9184-8763-2021-1704-2504-3521;pass:END;sub:END;*/

Shader "Shader Forge/Outline World Normal Tiled" {
    Properties {
        _OutlineWidth ("Outline Width", Range(0, 0.5)) = 0.01282051
        _OutlineColor ("Outline Color", Color) = (0,0,0,1)
        _Normal1 ("Normal 1", 2D) = "white" {}
        _Normal2 ("Normal 2", 2D) = "white" {}
        _Normal3 ("Normal 3", 2D) = "white" {}
        _Metallic1 ("Metallic 1", 2D) = "white" {}
        _Metallic2 ("Metallic 2", 2D) = "white" {}
        _Metallic3 ("Metallic 3", 2D) = "white" {}
        _Texture1 ("Texture 1", 2D) = "white" {}
        _Texture2 ("Texture 2", 2D) = "white" {}
        _Texture3 ("Texture 3", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float _OutlineWidth;
            uniform float4 _OutlineColor;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + normalize(v.vertex)*(distance(_WorldSpaceCameraPos,mul(unity_ObjectToWorld, v.vertex).rgb)*_OutlineWidth),1) );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_OutlineColor.rgb,0);
            }
            ENDCG
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Texture1; uniform float4 _Texture1_ST;
            uniform sampler2D _Texture2; uniform float4 _Texture2_ST;
            uniform sampler2D _Texture3; uniform float4 _Texture3_ST;
            uniform sampler2D _Metallic2; uniform float4 _Metallic2_ST;
            uniform sampler2D _Metallic3; uniform float4 _Metallic3_ST;
            uniform sampler2D _Metallic1; uniform float4 _Metallic1_ST;
            uniform sampler2D _Normal3; uniform float4 _Normal3_ST;
            uniform sampler2D _Normal2; uniform float4 _Normal2_ST;
            uniform sampler2D _Normal1; uniform float4 _Normal1_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 node_3116 = abs(i.normalDir);
                float3 node_8885 = (node_3116*node_3116);
                float2 node_7826 = float2(i.posWorld.g,i.posWorld.b);
                float4 _Normal1_var = tex2D(_Normal1,TRANSFORM_TEX(node_7826, _Normal1));
                float2 node_9709 = float2(i.posWorld.r,i.posWorld.b);
                float4 _Normal2_var = tex2D(_Normal2,TRANSFORM_TEX(node_9709, _Normal2));
                float2 node_1830 = float2(i.posWorld.r,i.posWorld.g);
                float4 _Normal3_var = tex2D(_Normal3,TRANSFORM_TEX(node_1830, _Normal3));
                float3 normalLocal = (node_8885.r*_Normal1_var.rgb + node_8885.g*_Normal2_var.rgb + node_8885.b*_Normal3_var.rgb);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _Metallic1_var = tex2D(_Metallic1,TRANSFORM_TEX(node_1830, _Metallic1));
                float4 _Metallic2_var = tex2D(_Metallic2,TRANSFORM_TEX(node_9709, _Metallic2));
                float4 _Metallic3_var = tex2D(_Metallic3,TRANSFORM_TEX(node_7826, _Metallic3));
                float gloss = (node_8885.r*_Metallic1_var.a + node_8885.g*_Metallic2_var.a + node_8885.b*_Metallic3_var.a);
                float perceptualRoughness = 1.0 - (node_8885.r*_Metallic1_var.a + node_8885.g*_Metallic2_var.a + node_8885.b*_Metallic3_var.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (node_8885.r*_Metallic1_var.r + node_8885.g*_Metallic2_var.r + node_8885.b*_Metallic3_var.r);
                float specularMonochrome;
                float4 _Texture1_var = tex2D(_Texture1,TRANSFORM_TEX(node_7826, _Texture1));
                float4 _Texture2_var = tex2D(_Texture2,TRANSFORM_TEX(node_9709, _Texture2));
                float4 _Texture3_var = tex2D(_Texture3,TRANSFORM_TEX(node_1830, _Texture3));
                float3 node_3082 = (node_8885.r*_Texture1_var.rgb + node_8885.g*_Texture2_var.rgb + node_8885.b*_Texture3_var.rgb); // Tileable World Space Textures
                float3 diffuseColor = node_3082; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += UNITY_LIGHTMODEL_AMBIENT.rgb; // Ambient Light
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float3 emissive = node_3082;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
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
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Texture1; uniform float4 _Texture1_ST;
            uniform sampler2D _Texture2; uniform float4 _Texture2_ST;
            uniform sampler2D _Texture3; uniform float4 _Texture3_ST;
            uniform sampler2D _Metallic2; uniform float4 _Metallic2_ST;
            uniform sampler2D _Metallic3; uniform float4 _Metallic3_ST;
            uniform sampler2D _Metallic1; uniform float4 _Metallic1_ST;
            uniform sampler2D _Normal3; uniform float4 _Normal3_ST;
            uniform sampler2D _Normal2; uniform float4 _Normal2_ST;
            uniform sampler2D _Normal1; uniform float4 _Normal1_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
                LIGHTING_COORDS(4,5)
                UNITY_FOG_COORDS(6)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 node_3116 = abs(i.normalDir);
                float3 node_8885 = (node_3116*node_3116);
                float2 node_7826 = float2(i.posWorld.g,i.posWorld.b);
                float4 _Normal1_var = tex2D(_Normal1,TRANSFORM_TEX(node_7826, _Normal1));
                float2 node_9709 = float2(i.posWorld.r,i.posWorld.b);
                float4 _Normal2_var = tex2D(_Normal2,TRANSFORM_TEX(node_9709, _Normal2));
                float2 node_1830 = float2(i.posWorld.r,i.posWorld.g);
                float4 _Normal3_var = tex2D(_Normal3,TRANSFORM_TEX(node_1830, _Normal3));
                float3 normalLocal = (node_8885.r*_Normal1_var.rgb + node_8885.g*_Normal2_var.rgb + node_8885.b*_Normal3_var.rgb);
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _Metallic1_var = tex2D(_Metallic1,TRANSFORM_TEX(node_1830, _Metallic1));
                float4 _Metallic2_var = tex2D(_Metallic2,TRANSFORM_TEX(node_9709, _Metallic2));
                float4 _Metallic3_var = tex2D(_Metallic3,TRANSFORM_TEX(node_7826, _Metallic3));
                float gloss = (node_8885.r*_Metallic1_var.a + node_8885.g*_Metallic2_var.a + node_8885.b*_Metallic3_var.a);
                float perceptualRoughness = 1.0 - (node_8885.r*_Metallic1_var.a + node_8885.g*_Metallic2_var.a + node_8885.b*_Metallic3_var.a);
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (node_8885.r*_Metallic1_var.r + node_8885.g*_Metallic2_var.r + node_8885.b*_Metallic3_var.r);
                float specularMonochrome;
                float4 _Texture1_var = tex2D(_Texture1,TRANSFORM_TEX(node_7826, _Texture1));
                float4 _Texture2_var = tex2D(_Texture2,TRANSFORM_TEX(node_9709, _Texture2));
                float4 _Texture3_var = tex2D(_Texture3,TRANSFORM_TEX(node_1830, _Texture3));
                float3 node_3082 = (node_8885.r*_Texture1_var.rgb + node_8885.g*_Texture2_var.rgb + node_8885.b*_Texture3_var.rgb); // Tileable World Space Textures
                float3 diffuseColor = node_3082; // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
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
