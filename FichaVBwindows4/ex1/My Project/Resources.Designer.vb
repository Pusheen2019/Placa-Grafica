﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código foi gerado por uma ferramenta.
'     Versão de Tempo de Execução:4.0.30319.42000
'
'     As alterações a este ficheiro poderão provocar um comportamento incorrecto e perder-se-ão se
'     o código for regenerado.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Esta classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    'através de uma ferramenta como o ResGen ou o Visual Studio.
    'Para adicionar ou remover um membro, edite o ficheiro .ResX e volte a executar o ResGen
    'com a opção /str ou reconstrua o projecto do VS.
    '''<summary>
    '''  Uma classe de recursos com tipo seguro para procurar cadeias localizadas, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Devolve a instância ResourceManager em cache utilizada para esta classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ex1.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Substitui a propriedade CurrentUICulture do thread actual para todas as
        '''  pesquisas de recursos que utilizem esta classe de recurso com tipo seguro.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Procura um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Terminator_2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Terminator 2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Procura um recurso localizado do tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Terminator_3_P5G965A() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Terminator 3 P5G965A", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
