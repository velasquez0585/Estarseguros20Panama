Imports System.Data.Objects
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.trazabilidad
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento

Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.log
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.usuario

Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.log
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.mantenimiento
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.agenda
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.agenda
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.usuario
Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace modelo.dbestarseguros20
    Public Class config


        Inherits ObjectContext


#Region "declaraciones"
        Private _segmanusu As ObjectSet(Of segmanusu)
        Private _segmancarg As ObjectSet(Of segmancarg)
        Private _segmandep As ObjectSet(Of segmandep)

        Private _seglogerr As ObjectSet(Of seglogerr)

        Private _vi_segmanusu As ObjectSet(Of vi_segmanusu)
        Private _vi_segusuperf As ObjectSet(Of vi_segusuperf)
        Private _vi_segappprog As ObjectSet(Of vi_segappprog)
        Private _vi_segaccperf As ObjectSet(Of vi_segaccperf)
        Private _vi_segusudetperf2 As ObjectSet(Of vi_segusudetperf2)
        Private _vi_segappperf As ObjectSet(Of vi_segappperf)
        Private _vi_combosegmanorg As ObjectSet(Of vi_combosegmanorg)

        '-- comun
        Private _comunconfcontad As ObjectSet(Of comunconfcontad)
        Private _comunconfsmtp As ObjectSet(Of comunconfsmtp)
        Private _comunconfvalor As ObjectSet(Of comunconfvalor)
        Private _comunmancom As ObjectSet(Of comunmancom)
        Private _comunmancont As ObjectSet(Of comunmancont)
        Private _comunmandir As ObjectSet(Of comunmandir)
        Private _comunmanempr As ObjectSet(Of comunmanempr)
        Private _comunmanestado As ObjectSet(Of comunmanestado)
        Private _comunmanlocalid As ObjectSet(Of comunmanlocalid)
        Private _comunmanpais As ObjectSet(Of comunmanpais)
        Private _comunmanpers As ObjectSet(Of comunmanpers)
        '--fin comun

        '--aipiauto
        '
        '------baremos
        Private _aipbaremobr As ObjectSet(Of aipbaremobr)
        Private _aipbarerepu As ObjectSet(Of aipbarerepu)
        '-------vistas
        Private _vi_aipbaremobr As ObjectSet(Of vi_aipbaremobr)
        Private _vi_aipbarerepu As ObjectSet(Of vi_aipbarerepu)
        Private _vi_comboaipbarerepuorig As ObjectSet(Of vi_comboaipbarerepuorig)
        Private _vi_comboaipbaremobrtama As ObjectSet(Of vi_comboaipbaremobrtama)
        Private _vi_comboaipbaremobrmater As ObjectSet(Of vi_comboaipbaremobrmater)
        Private _vi_comboaipbaremobrmobr As ObjectSet(Of vi_comboaipbaremobrmobr)
        '------fin baremos
        'agenda
        Private _aipactivperi As ObjectSet(Of aipactivperi)
        '
        '------inspeccion
        Private _aipinsajusanex As ObjectSet(Of aipinsajusanex)
        Private _aipinsajusanexmobr As ObjectSet(Of aipinsajusanexmobr)
        Private _aipinsajusanexrepu As ObjectSet(Of aipinsajusanexrepu)
        Private _aipinsajussin As ObjectSet(Of aipinsajussin)
        Private _aipinsajussinmobr As ObjectSet(Of aipinsajussinmobr)
        Private _aipinsajussinrepu As ObjectSet(Of aipinsajussinrepu)
        Private _aipinsenc As ObjectSet(Of aipinsenc)
        Private _aipinsfoto As ObjectSet(Of aipinsfoto)
        Private _aipinsarch As ObjectSet(Of aipinsarch)
        Private _aipinslimsin As ObjectSet(Of aipinslimsin)
        Private _aipinslimsinmobr As ObjectSet(Of aipinslimsinmobr)
        Private _aipinslimsinrepu As ObjectSet(Of aipinslimsinrepu)
        Private _aipinslimsus As ObjectSet(Of aipinslimsus)
        Private _aipinslimsusmobr As ObjectSet(Of aipinslimsusmobr)
        Private _aipinslimsusrepu As ObjectSet(Of aipinslimsusrepu)
        Private _aipinsmotiv As ObjectSet(Of aipinsmotiv)
        Private _aipinsrest As ObjectSet(Of aipinsrest)
        Private _aipinsrestrepuest As ObjectSet(Of aipinsrestrepuest)
        Private _aipinsrestsse As ObjectSet(Of aipinsrestsse)
        Private _aipinsrestssm As ObjectSet(Of aipinsrestssm)
        Private _aipinssus As ObjectSet(Of aipinssus)
        Private _aipinssusacc As ObjectSet(Of aipinssusacc)
        Private _aipinssusmotiv As ObjectSet(Of aipinssusmotiv)
        Private _aipinssusrepuest As ObjectSet(Of aipinssusrepuest)
        Private _aipinssussse As ObjectSet(Of aipinssussse)
        Private _aipinssusssm As ObjectSet(Of aipinssusssm)

        Private _aipinssinrepu As ObjectSet(Of aipinssinrepu)
        Private _aipinssin As ObjectSet(Of aipinssin)
        Private _aipinssinmobr As ObjectSet(Of aipinssinmobr)


        Private _aipinssinmotiv As ObjectSet(Of aipinssinmotiv)




        '--------vistas
        Private _vi_aipinsajusanex As ObjectSet(Of vi_aipinsajusanex)
        Private _vi_aipinsajusanexmobr As ObjectSet(Of vi_aipinsajusanexmobr)
        Private _vi_aipinsajusanexrepu As ObjectSet(Of vi_aipinsajusanexrepu)
        Private _vi_aipinsajussin As ObjectSet(Of vi_aipinsajussin)
        Private _vi_aipinsajussinmobr As ObjectSet(Of vi_aipinsajussinmobr)
        Private _vi_aipinsajussinrepu As ObjectSet(Of vi_aipinsajussinrepu)
        Private _vi_aipinsenc As ObjectSet(Of vi_aipinsenc)
        Private _vi_aipinsfoto As ObjectSet(Of vi_aipinsfoto)
        Private _vi_aipinsarch As ObjectSet(Of vi_aipinsarch)
        Private _vi_aipinslimsin As ObjectSet(Of vi_aipinslimsin)
        Private _vi_aipinslimsinmobr As ObjectSet(Of vi_aipinslimsinmobr)
        Private _vi_aipinslimsinrepu As ObjectSet(Of vi_aipinslimsinrepu)
        Private _vi_aipinslimsus As ObjectSet(Of vi_aipinslimsus)
        Private _vi_aipinslimsusmobr As ObjectSet(Of vi_aipinslimsusmobr)
        Private _vi_aipinslimsusrepu As ObjectSet(Of vi_aipinslimsusrepu)
        'Private _vi_aipinsmotiv As ObjectSet(Of vi_aipinsmotiv)
        Private _vi_aipinsrest As ObjectSet(Of vi_aipinsrest)
        Private _vi_aipinsrestrepuest As ObjectSet(Of vi_aipinsrestrepuest)
        Private _vi_aipinsrestsse As ObjectSet(Of vi_aipinsrestsse)
        Private _vi_aipinsrestssm As ObjectSet(Of vi_aipinsrestssm)
        Private _vi_aipinssus As ObjectSet(Of vi_aipinssus)
        Private _vi_aipinssusacc As ObjectSet(Of vi_aipinssusacc)
        Private _vi_aipinssusmotiv As ObjectSet(Of vi_aipinssusmotiv)
        Private _vi_aipinssusrepuest As ObjectSet(Of vi_aipinssusrepuest)
        Private _vi_aipinssussse As ObjectSet(Of vi_aipinssussse)
        Private _vi_aipinssusssm As ObjectSet(Of vi_aipinssusssm)
        Private _vi_aipactivperi As ObjectSet(Of vi_aipactivperi)
        Private _vi_aipactivperidet As ObjectSet(Of vi_aipactivperidet)
        Private _vi_aipinsajussinmobragrup As ObjectSet(Of vi_aipinsajussinmobragrup)
        Private _vi_aipinsajusanexmobragrup As ObjectSet(Of vi_aipinsajusanexmobragrup)

        Private _vi_aipinsdistperit As ObjectSet(Of vi_aipinsdistperit)
        Private _vi_aipinsdistperitperf As ObjectSet(Of vi_aipinsdistperitperf)
        Private _vi_aipinsdistaudit As ObjectSet(Of vi_aipinsdistaudit)
        Private _vi_aipinsdistauditperf As ObjectSet(Of vi_aipinsdistauditperf)

        Private _vi_aipinsdistperitdet As ObjectSet(Of vi_aipinsdistperitdet)
        Private _vi_aipinsdistauditdet As ObjectSet(Of vi_aipinsdistauditdet)

        Private _vi_aipinssinrepu As ObjectSet(Of vi_aipinssinrepu)
        Private _vi_aipinssin As ObjectSet(Of vi_aipinssin)
        Private _vi_aipinssinmobr As ObjectSet(Of vi_aipinssinmobr)

        Private _vi_aipinssinmotiv As ObjectSet(Of vi_aipinssinmotiv)
        Private _vi_aipinssusinfcomp As ObjectSet(Of vi_aipinssusinfcomp)

        Private _vi_aipinsencdet As ObjectSet(Of vi_aipinsencdet)

        Private _vi_aipinsperitagrup As ObjectSet(Of vi_aipinsperitagrup)
        Private _vi_aipinsauditagrup As ObjectSet(Of vi_aipinsauditagrup)

        Private _vi_intermediacion As ObjectSet(Of vi_intermediacion)
        Private _vi_aipextsintagenda As ObjectSet(Of vi_aipextsintagenda)

        '------fin inspeccion
        '        
        '------log
        Private _aiplogeve As ObjectSet(Of aiplogeve)
        '-------vistas
        Private _vi_aiplogeve As ObjectSet(Of vi_aiplogeve)
        '------fin log
        '
        '------mantenimiento
        Private _aipmandisp As ObjectSet(Of aipmandisp)
        Private _aipmanrepu As ObjectSet(Of aipmanrepu)
        Private _aipmanveh As ObjectSet(Of aipmanveh)
        Private _aipmanvehacc As ObjectSet(Of aipmanvehacc)
        Private _aipmanvehmar As ObjectSet(Of aipmanvehmar)
        Private _aipmanvehmod As ObjectSet(Of aipmanvehmod)
        Private _aipmanvehsse As ObjectSet(Of aipmanvehsse)
        Private _aipmanvehssm As ObjectSet(Of aipmanvehssm)
        Private _aipmanvehver As ObjectSet(Of aipmanvehver)
        Private _aipmaninfcomp As ObjectSet(Of aipmaninfcomp)
        Private _aipinssusinfcomp As ObjectSet(Of aipinssusinfcomp)


        '---------vistas
        'Private _vi_aipmandisp As ObjectSet(Of vi_aipmandisp)
        Private _vi_aipmanrepu As ObjectSet(Of vi_aipmanrepu)
        Private _vi_aipmanveh As ObjectSet(Of vi_aipmanveh)
        Private _vi_aipmanvehmod As ObjectSet(Of vi_aipmanvehmod)
        Private _vi_aipmanvehver As ObjectSet(Of vi_aipmanvehver)

        'Private _vi_aipmanvehacc As ObjectSet(Of vi_aipmanvehacc)
        'Private _vi_aipmanvehmar As ObjectSet(Of vi_aipmanvehmar)
        'Private _vi_aipmanvehmod As ObjectSet(Of vi_aipmanvehmod)
        'Private _vi_aipmanvehsse As ObjectSet(Of vi_aipmanvehsse)
        'Private _vi_aipmanvehssm As ObjectSet(Of vi_aipmanvehssm)
        'Private _vi_aipmanvehver As ObjectSet(Of vi_aipmanvehver)
        '
        '------fin mantenimiento

        '------usuario
        '
        Private _aipusudisp As ObjectSet(Of aipusudisp)
        Private _vi_aipusudisp As ObjectSet(Of vi_aipusudisp)

        Private _aipmanusuconf As ObjectSet(Of aipmanusuconf)
        Private _vi_aipmanusuconf As ObjectSet(Of vi_aipmanusuconf)
        Private _vi_aipmanusuconfperf As ObjectSet(Of vi_aipmanusuconfperf)
        '------fin usuario
        '
        '--fin aipiauto

        'para los baremos con el codigo baremos externos, esta como personalizado
        Private _aipgenobj As ObjectSet(Of aipgenobj)

#End Region

#Region "constructores"
        Public Sub New()
            MyBase.New("name=cnxdbestarseguros20" & ConfigurationManager.AppSettings("motoddb"), "cnxdbestarseguros20" & ConfigurationManager.AppSettings("motoddb"))
            ContextOptions.LazyLoadingEnabled = False
            ContextOptions.ProxyCreationEnabled = False

            _segmanusu = CreateObjectSet(Of segmanusu)("segmanusu")
            _segmancarg = CreateObjectSet(Of segmancarg)("segmancarg")
            _segmandep = CreateObjectSet(Of segmandep)("segmandep")

            _seglogerr = CreateObjectSet(Of seglogerr)("seglogerr")

            _vi_segmanusu = CreateObjectSet(Of vi_segmanusu)("vi_segmanusu")
            _vi_segusuperf = CreateObjectSet(Of vi_segusuperf)("vi_segusuperf")
            _vi_segappprog = CreateObjectSet(Of vi_segappprog)("vi_segappprog")
            _vi_segaccperf = CreateObjectSet(Of vi_segaccperf)("vi_segaccperf")
            _vi_segusudetperf2 = CreateObjectSet(Of vi_segusudetperf2)("vi_segusudetperf2")
            _vi_segappperf = CreateObjectSet(Of vi_segappperf)("vi_segappperf")
            _vi_combosegmanorg = CreateObjectSet(Of vi_combosegmanorg)("vi_combosegmanorg")




            '-- comun
            _comunconfcontad = CreateObjectSet(Of comunconfcontad)("comunconfcontad")
            _comunconfsmtp = CreateObjectSet(Of comunconfsmtp)("comunconfsmtp")
            _comunconfvalor = CreateObjectSet(Of comunconfvalor)("comunconfvalor")
            _comunmancom = CreateObjectSet(Of comunmancom)("comunmancom")
            _comunmancont = CreateObjectSet(Of comunmancont)("comunmancont")
            _comunmandir = CreateObjectSet(Of comunmandir)("comunmandir")
            _comunmanempr = CreateObjectSet(Of comunmanempr)("comunmanempr")
            _comunmanestado = CreateObjectSet(Of comunmanestado)("comunmanestado")
            _comunmanlocalid = CreateObjectSet(Of comunmanlocalid)("comunmanlocalid")
            _comunmanpais = CreateObjectSet(Of comunmanpais)("comunmanpais")
            _comunmanpers = CreateObjectSet(Of comunmanpers)("comunmanpers")
            '--fin comun

            '--aipiauto
            '
            '------baremos
            _aipbaremobr = CreateObjectSet(Of aipbaremobr)("aipbaremobr")
            _aipbarerepu = CreateObjectSet(Of aipbarerepu)("aipbarerepu")
            '-------vistas
            _vi_aipbaremobr = CreateObjectSet(Of vi_aipbaremobr)("vi_aipbaremobr")
            _vi_aipbarerepu = CreateObjectSet(Of vi_aipbarerepu)("vi_aipbarerepu")
            _vi_comboaipbarerepuorig = CreateObjectSet(Of vi_comboaipbarerepuorig)("vi_comboaipbarerepuorig")
            _vi_comboaipbaremobrtama = CreateObjectSet(Of vi_comboaipbaremobrtama)("vi_comboaipbaremobrtama")
            _vi_comboaipbaremobrmater = CreateObjectSet(Of vi_comboaipbaremobrmater)("vi_comboaipbaremobrmater")
            _vi_comboaipbaremobrmobr = CreateObjectSet(Of vi_comboaipbaremobrmobr)("vi_comboaipbaremobrmobr")
            '------fin baremos
            'agenda
            _aipactivperi = CreateObjectSet(Of aipactivperi)("aipactivperi")
            '
            '------inspeccion
            _aipinsajusanex = CreateObjectSet(Of aipinsajusanex)("aipinsajusanex")
            _aipinsajusanexmobr = CreateObjectSet(Of aipinsajusanexmobr)("aipinsajusanexmobr")
            _aipinsajusanexrepu = CreateObjectSet(Of aipinsajusanexrepu)("aipinsajusanexrepu")
            _aipinsajussin = CreateObjectSet(Of aipinsajussin)("aipinsajussin")
            _aipinsajussinmobr = CreateObjectSet(Of aipinsajussinmobr)("aipinsajussinmobr")
            _aipinsajussinrepu = CreateObjectSet(Of aipinsajussinrepu)("aipinsajussinrepu")
            _aipinsenc = CreateObjectSet(Of aipinsenc)("aipinsenc")
            _aipinsfoto = CreateObjectSet(Of aipinsfoto)("aipinsfoto")
            _aipinsarch = CreateObjectSet(Of aipinsarch)("aipinsarch")
            _aipinslimsin = CreateObjectSet(Of aipinslimsin)("aipinslimsin")
            _aipinslimsinmobr = CreateObjectSet(Of aipinslimsinmobr)("aipinslimsinmobr")
            _aipinslimsinrepu = CreateObjectSet(Of aipinslimsinrepu)("aipinslimsinrepu")
            _aipinslimsus = CreateObjectSet(Of aipinslimsus)("aipinslimsus")
            _aipinslimsusmobr = CreateObjectSet(Of aipinslimsusmobr)("aipinslimsusmobr")
            _aipinslimsusrepu = CreateObjectSet(Of aipinslimsusrepu)("aipinslimsusrepu")
            _aipinsmotiv = CreateObjectSet(Of aipinsmotiv)("aipinsmotiv")
            _aipinsrest = CreateObjectSet(Of aipinsrest)("aipinsrest")
            _aipinsrestrepuest = CreateObjectSet(Of aipinsrestrepuest)("aipinsrestrepuest")
            _aipinsrestsse = CreateObjectSet(Of aipinsrestsse)("aipinsrestsse")
            _aipinsrestssm = CreateObjectSet(Of aipinsrestssm)("aipinsrestssm")
            _aipinssus = CreateObjectSet(Of aipinssus)("aipinssus")
            _aipinssusacc = CreateObjectSet(Of aipinssusacc)("aipinssusacc")
            _aipinssusmotiv = CreateObjectSet(Of aipinssusmotiv)("aipinssusmotiv")
            _aipinssusrepuest = CreateObjectSet(Of aipinssusrepuest)("aipinssusrepuest")
            _aipinssussse = CreateObjectSet(Of aipinssussse)("aipinssussse")
            _aipinssusssm = CreateObjectSet(Of aipinssusssm)("aipinssusssm")


            _aipinssinrepu = CreateObjectSet(Of aipinssinrepu)("aipinssinrepu")
            _aipinssin = CreateObjectSet(Of aipinssin)("aipinssin")
            _aipinssinmobr = CreateObjectSet(Of aipinssinmobr)("aipinssinmobr")

            _aipinssinmotiv = CreateObjectSet(Of aipinssinmotiv)("aipinssinmotiv")


            '----------vistas
            _vi_aipinsajusanex = CreateObjectSet(Of vi_aipinsajusanex)("vi_aipinsajusanex")
            _vi_aipinsajusanexmobr = CreateObjectSet(Of vi_aipinsajusanexmobr)("vi_aipinsajusanexmobr")
            _vi_aipinsajusanexrepu = CreateObjectSet(Of vi_aipinsajusanexrepu)("vi_aipinsajusanexrepu")
            _vi_aipinsajussin = CreateObjectSet(Of vi_aipinsajussin)("vi_aipinsajussin")
            _vi_aipinsajussinmobr = CreateObjectSet(Of vi_aipinsajussinmobr)("vi_aipinsajussinmobr")
            _vi_aipinsajussinrepu = CreateObjectSet(Of vi_aipinsajussinrepu)("vi_aipinsajussinrepu")
            _vi_aipinsenc = CreateObjectSet(Of vi_aipinsenc)("vi_aipinsenc")
            _vi_aipinsfoto = CreateObjectSet(Of vi_aipinsfoto)("vi_aipinsfoto")
            _vi_aipinsarch = CreateObjectSet(Of vi_aipinsarch)("vi_aipinsarch")
            _vi_aipinslimsin = CreateObjectSet(Of vi_aipinslimsin)("vi_aipinslimsin")
            _vi_aipinslimsinmobr = CreateObjectSet(Of vi_aipinslimsinmobr)("vi_aipinslimsinmobr")
            _vi_aipinslimsinrepu = CreateObjectSet(Of vi_aipinslimsinrepu)("vi_aipinslimsinrepu")
            _vi_aipinslimsus = CreateObjectSet(Of vi_aipinslimsus)("vi_aipinslimsus")
            _vi_aipinslimsusmobr = CreateObjectSet(Of vi_aipinslimsusmobr)("vi_aipinslimsusmobr")
            _vi_aipinslimsusrepu = CreateObjectSet(Of vi_aipinslimsusrepu)("vi_aipinslimsusrepu")
            '_vi_aipinsmotiv = CreateObjectSet(Of vi_aipinsmotiv)("vi_aipinsmotiv")
            _vi_aipinsrest = CreateObjectSet(Of vi_aipinsrest)("vi_aipinsrest")
            _vi_aipinsrestrepuest = CreateObjectSet(Of vi_aipinsrestrepuest)("vi_aipinsrestrepuest")
            _vi_aipinsrestsse = CreateObjectSet(Of vi_aipinsrestsse)("vi_aipinsrestsse")
            _vi_aipinsrestssm = CreateObjectSet(Of vi_aipinsrestssm)("vi_aipinsrestssm")
            _vi_aipinssus = CreateObjectSet(Of vi_aipinssus)("vi_aipinssus")
            _vi_aipinssusacc = CreateObjectSet(Of vi_aipinssusacc)("vi_aipinssusacc")
            _vi_aipinssusmotiv = CreateObjectSet(Of vi_aipinssusmotiv)("vi_aipinssusmotiv")
            _vi_aipinssusrepuest = CreateObjectSet(Of vi_aipinssusrepuest)("vi_aipinssusrepuest")
            _vi_aipinssussse = CreateObjectSet(Of vi_aipinssussse)("vi_aipinssussse")
            _vi_aipinssusssm = CreateObjectSet(Of vi_aipinssusssm)("vi_aipinssusssm")
            _vi_aipactivperi = CreateObjectSet(Of vi_aipactivperi)("vi_aipactivperi")
            _vi_aipactivperidet = CreateObjectSet(Of vi_aipactivperidet)("vi_aipactivperidet")
            _vi_aipinsajussinmobragrup = CreateObjectSet(Of vi_aipinsajussinmobragrup)("vi_aipinsajussinmobragrup")
            _vi_aipinsajusanexmobragrup = CreateObjectSet(Of vi_aipinsajusanexmobragrup)("vi_aipinsajusanexmobragrup")


            _vi_aipinsdistperit = CreateObjectSet(Of vi_aipinsdistperit)("vi_aipinsdistperit")
            _vi_aipinsdistperitperf = CreateObjectSet(Of vi_aipinsdistperitperf)("vi_aipinsdistperitperf")
            _vi_aipinsdistaudit = CreateObjectSet(Of vi_aipinsdistaudit)("vi_aipinsdistaudit")
            _vi_aipinsdistauditperf = CreateObjectSet(Of vi_aipinsdistauditperf)("vi_aipinsdistauditperf")

            _vi_aipinsdistperitdet = CreateObjectSet(Of vi_aipinsdistperitdet)("vi_aipinsdistperitdet")
            _vi_aipinsdistauditdet = CreateObjectSet(Of vi_aipinsdistauditdet)("vi_aipinsdistauditdet")


            _vi_aipinsencdet = CreateObjectSet(Of vi_aipinsencdet)("vi_aipinsencdet")

            _vi_aipinssinrepu = CreateObjectSet(Of vi_aipinssinrepu)("vi_aipinssinrepu")
            _vi_aipinssin = CreateObjectSet(Of vi_aipinssin)("vi_aipinssin")
            _vi_aipinssinmobr = CreateObjectSet(Of vi_aipinssinmobr)("vi_aipinssinmobr")

            _vi_aipinssinmotiv = CreateObjectSet(Of vi_aipinssinmotiv)("vi_aipinssinmotiv")
            _vi_aipinssusinfcomp = CreateObjectSet(Of vi_aipinssusinfcomp)("vi_aipinssusinfcomp")

            _vi_aipinsperitagrup = CreateObjectSet(Of vi_aipinsperitagrup)("vi_aipinsperitagrup")
            _vi_aipinsauditagrup = CreateObjectSet(Of vi_aipinsauditagrup)("vi_aipinsauditagrup")

            _vi_intermediacion = CreateObjectSet(Of vi_intermediacion)("vi_intermediacion")
            _vi_aipextsintagenda = CreateObjectSet(Of vi_aipextsintagenda)("vi_aipextsintagenda")



            '------fin inspeccion
            '        
            '------log            
            _aiplogeve = CreateObjectSet(Of aiplogeve)("aiplogeve")
            '-----vistas
            _vi_aiplogeve = CreateObjectSet(Of vi_aiplogeve)("vi_aiplogeve")
            '------fin log
            '
            '------mantenimiento            
            _aipmandisp = CreateObjectSet(Of aipmandisp)("aipmandisp")
            _aipmanrepu = CreateObjectSet(Of aipmanrepu)("aipmanrepu")
            _aipmanveh = CreateObjectSet(Of aipmanveh)("aipmanveh")
            _aipmanvehacc = CreateObjectSet(Of aipmanvehacc)("aipmanvehacc")
            _aipmanvehmar = CreateObjectSet(Of aipmanvehmar)("aipmanvehmar")
            _aipmanvehmod = CreateObjectSet(Of aipmanvehmod)("aipmanvehmod")
            _aipmanvehsse = CreateObjectSet(Of aipmanvehsse)("aipmanvehsse")
            _aipmanvehssm = CreateObjectSet(Of aipmanvehssm)("aipmanvehssm")
            _aipmanvehver = CreateObjectSet(Of aipmanvehver)("aipmanvehver")
            _aipmaninfcomp = CreateObjectSet(Of aipmaninfcomp)("aipmaninfcomp")
            _aipinssusinfcomp = CreateObjectSet(Of aipinssusinfcomp)("aipinssusinfcomp")


            '-------vistas
            '_vi_aipmandisp = CreateObjectSet(Of vi_aipmandisp)("vi_aipmandisp")
            _vi_aipmanrepu = CreateObjectSet(Of vi_aipmanrepu)("vi_aipmanrepu")
            _vi_aipmanveh = CreateObjectSet(Of vi_aipmanveh)("vi_aipmanveh")
            _vi_aipmanvehmod = CreateObjectSet(Of vi_aipmanvehmod)("vi_aipmanvehmod")
            _vi_aipmanvehver = CreateObjectSet(Of vi_aipmanvehver)("vi_aipmanvehver")

            '_vi_aipmanvehacc = CreateObjectSet(Of vi_aipmanvehacc)("vi_aipmanvehacc")
            '_vi_aipmanvehmar = CreateObjectSet(Of vi_aipmanvehmar)("vi_aipmanvehmar")
            '_vi_aipmanvehmod = CreateObjectSet(Of vi_aipmanvehmod)("vi_aipmanvehmod")
            '_vi_aipmanvehsse = CreateObjectSet(Of vi_aipmanvehsse)("vi_aipmanvehsse")
            '_vi_aipmanvehssm = CreateObjectSet(Of vi_aipmanvehssm)("vi_aipmanvehssm")
            '_vi_aipmanvehver = CreateObjectSet(Of vi_aipmanvehver)("vi_aipmanvehver")
            '
            '------fin mantenimiento

            '------usuario
            '            
            _aipusudisp = CreateObjectSet(Of aipusudisp)("aipusudisp")
            _vi_aipusudisp = CreateObjectSet(Of vi_aipusudisp)("vi_aipusudisp")

            _aipmanusuconf = CreateObjectSet(Of aipmanusuconf)("aipmanusuconf")
            _vi_aipmanusuconf = CreateObjectSet(Of vi_aipmanusuconf)("vi_aipmanusuconf")
            _vi_aipmanusuconfperf = CreateObjectSet(Of vi_aipmanusuconfperf)("vi_aipmanusuconfperf")

            '------fin usuario
            '
            '--fin aipiauto
            'para el personalizado de repuestos para traer tambien el codigo externos
            _aipgenobj = CreateObjectSet(Of aipgenobj)("aipgenobj")


        End Sub

        Public Sub New(cnx As String)
            MyBase.New("name=" & cnx, "cnxdbestarseguros20" & ConfigurationManager.AppSettings("motoddb"))
            ContextOptions.LazyLoadingEnabled = False
            ContextOptions.ProxyCreationEnabled = False

            _segmanusu = CreateObjectSet(Of segmanusu)("segmanusu")
            _segmancarg = CreateObjectSet(Of segmancarg)("segmancarg")
            _segmandep = CreateObjectSet(Of segmandep)("segmandep")

            _seglogerr = CreateObjectSet(Of seglogerr)("seglogerr")

            _vi_segmanusu = CreateObjectSet(Of vi_segmanusu)("vi_segmanusu")
            _vi_segusuperf = CreateObjectSet(Of vi_segusuperf)("vi_segusuperf")
            _vi_segappprog = CreateObjectSet(Of vi_segappprog)("vi_segappprog")
            _vi_segaccperf = CreateObjectSet(Of vi_segaccperf)("vi_segaccperf")
            _vi_segusudetperf2 = CreateObjectSet(Of vi_segusudetperf2)("vi_segusudetperf2")
            _vi_segappperf = CreateObjectSet(Of vi_segappperf)("vi_segappperf")
            _vi_combosegmanorg = CreateObjectSet(Of vi_combosegmanorg)("vi_combosegmanorg")

            '-- comun
            _comunconfcontad = CreateObjectSet(Of comunconfcontad)("comunconfcontad")
            _comunconfsmtp = CreateObjectSet(Of comunconfsmtp)("comunconfsmtp")
            _comunconfvalor = CreateObjectSet(Of comunconfvalor)("comunconfvalor")
            _comunmancom = CreateObjectSet(Of comunmancom)("comunmancom")
            _comunmancont = CreateObjectSet(Of comunmancont)("comunmancont")
            _comunmandir = CreateObjectSet(Of comunmandir)("comunmandir")
            _comunmanempr = CreateObjectSet(Of comunmanempr)("comunmanempr")
            _comunmanestado = CreateObjectSet(Of comunmanestado)("comunmanestado")
            _comunmanlocalid = CreateObjectSet(Of comunmanlocalid)("comunmanlocalid")
            _comunmanpais = CreateObjectSet(Of comunmanpais)("comunmanpais")
            _comunmanpers = CreateObjectSet(Of comunmanpers)("comunmanpers")
            '--fin comun

            '--aipiauto
            '
            '------baremos
            _aipbaremobr = CreateObjectSet(Of aipbaremobr)("aipbaremobr")
            _aipbarerepu = CreateObjectSet(Of aipbarerepu)("aipbarerepu")
            '-------vistas
            _vi_aipbaremobr = CreateObjectSet(Of vi_aipbaremobr)("vi_aipbaremobr")
            _vi_aipbarerepu = CreateObjectSet(Of vi_aipbarerepu)("vi_aipbarerepu")
            _vi_comboaipbarerepuorig = CreateObjectSet(Of vi_comboaipbarerepuorig)("vi_comboaipbarerepuorig")
            _vi_comboaipbaremobrtama = CreateObjectSet(Of vi_comboaipbaremobrtama)("vi_comboaipbaremobrtama")
            _vi_comboaipbaremobrmater = CreateObjectSet(Of vi_comboaipbaremobrmater)("vi_comboaipbaremobrmater")
            _vi_comboaipbaremobrmobr = CreateObjectSet(Of vi_comboaipbaremobrmobr)("vi_comboaipbaremobrmobr")
            '------fin baremos
            'agenda
            _aipactivperi = CreateObjectSet(Of aipactivperi)("aipactivperi")
            '
            '------inspeccion
            _aipinsajusanex = CreateObjectSet(Of aipinsajusanex)("aipinsajusanex")
            _aipinsajusanexmobr = CreateObjectSet(Of aipinsajusanexmobr)("aipinsajusanexmobr")
            _aipinsajusanexrepu = CreateObjectSet(Of aipinsajusanexrepu)("aipinsajusanexrepu")
            _aipinsajussin = CreateObjectSet(Of aipinsajussin)("aipinsajussin")
            _aipinsajussinmobr = CreateObjectSet(Of aipinsajussinmobr)("aipinsajussinmobr")
            _aipinsajussinrepu = CreateObjectSet(Of aipinsajussinrepu)("aipinsajussinrepu")
            _aipinsenc = CreateObjectSet(Of aipinsenc)("aipinsenc")
            _aipinsfoto = CreateObjectSet(Of aipinsfoto)("aipinsfoto")
            _aipinsarch = CreateObjectSet(Of aipinsarch)("aipinsarch")
            _aipinslimsin = CreateObjectSet(Of aipinslimsin)("aipinslimsin")
            _aipinslimsinmobr = CreateObjectSet(Of aipinslimsinmobr)("aipinslimsinmobr")
            _aipinslimsinrepu = CreateObjectSet(Of aipinslimsinrepu)("aipinslimsinrepu")
            _aipinslimsus = CreateObjectSet(Of aipinslimsus)("aipinslimsus")
            _aipinslimsusmobr = CreateObjectSet(Of aipinslimsusmobr)("aipinslimsusmobr")
            _aipinslimsusrepu = CreateObjectSet(Of aipinslimsusrepu)("aipinslimsusrepu")
            _aipinsmotiv = CreateObjectSet(Of aipinsmotiv)("aipinsmotiv")
            _aipinsrest = CreateObjectSet(Of aipinsrest)("aipinsrest")
            _aipinsrestrepuest = CreateObjectSet(Of aipinsrestrepuest)("aipinsrestrepuest")
            _aipinsrestsse = CreateObjectSet(Of aipinsrestsse)("aipinsrestsse")
            _aipinsrestssm = CreateObjectSet(Of aipinsrestssm)("aipinsrestssm")
            _aipinssus = CreateObjectSet(Of aipinssus)("aipinssus")
            _aipinssusacc = CreateObjectSet(Of aipinssusacc)("aipinssusacc")
            _aipinssusmotiv = CreateObjectSet(Of aipinssusmotiv)("aipinssusmotiv")
            _aipinssusrepuest = CreateObjectSet(Of aipinssusrepuest)("aipinssusrepuest")
            _aipinssussse = CreateObjectSet(Of aipinssussse)("aipinssussse")
            _aipinssusssm = CreateObjectSet(Of aipinssusssm)("aipinssusssm")

            _aipinssinrepu = CreateObjectSet(Of aipinssinrepu)("aipinssinrepu")
            _aipinssin = CreateObjectSet(Of aipinssin)("aipinssin")
            _aipinssinmobr = CreateObjectSet(Of aipinssinmobr)("aipinssinmobr")

            _aipinssinmotiv = CreateObjectSet(Of aipinssinmotiv)("aipinssinmotiv")  'falta en oracle


            '----------vistas
            _vi_aipinsajusanex = CreateObjectSet(Of vi_aipinsajusanex)("vi_aipinsajusanex")
            _vi_aipinsajusanexmobr = CreateObjectSet(Of vi_aipinsajusanexmobr)("vi_aipinsajusanexmobr")
            _vi_aipinsajusanexrepu = CreateObjectSet(Of vi_aipinsajusanexrepu)("vi_aipinsajusanexrepu")
            _vi_aipinsajussin = CreateObjectSet(Of vi_aipinsajussin)("vi_aipinsajussin")
            _vi_aipinsajussinmobr = CreateObjectSet(Of vi_aipinsajussinmobr)("vi_aipinsajussinmobr")
            _vi_aipinsajussinrepu = CreateObjectSet(Of vi_aipinsajussinrepu)("vi_aipinsajussinrepu")
            _vi_aipinsenc = CreateObjectSet(Of vi_aipinsenc)("vi_aipinsenc")
            _vi_aipinsfoto = CreateObjectSet(Of vi_aipinsfoto)("vi_aipinsfoto")
            _vi_aipinsarch = CreateObjectSet(Of vi_aipinsarch)("vi_aipinsarch")
            _vi_aipinslimsin = CreateObjectSet(Of vi_aipinslimsin)("vi_aipinslimsin")
            _vi_aipinslimsinmobr = CreateObjectSet(Of vi_aipinslimsinmobr)("vi_aipinslimsinmobr")
            _vi_aipinslimsinrepu = CreateObjectSet(Of vi_aipinslimsinrepu)("vi_aipinslimsinrepu")
            _vi_aipinslimsus = CreateObjectSet(Of vi_aipinslimsus)("vi_aipinslimsus")
            _vi_aipinslimsusmobr = CreateObjectSet(Of vi_aipinslimsusmobr)("vi_aipinslimsusmobr")
            _vi_aipinslimsusrepu = CreateObjectSet(Of vi_aipinslimsusrepu)("vi_aipinslimsusrepu")
            _vi_aipinsrest = CreateObjectSet(Of vi_aipinsrest)("vi_aipinsrest")
            _vi_aipinsrestrepuest = CreateObjectSet(Of vi_aipinsrestrepuest)("vi_aipinsrestrepuest")
            _vi_aipinsrestsse = CreateObjectSet(Of vi_aipinsrestsse)("vi_aipinsrestsse")
            _vi_aipinsrestssm = CreateObjectSet(Of vi_aipinsrestssm)("vi_aipinsrestssm")
            _vi_aipinssus = CreateObjectSet(Of vi_aipinssus)("vi_aipinssus")
            _vi_aipinssusacc = CreateObjectSet(Of vi_aipinssusacc)("vi_aipinssusacc")
            _vi_aipinssusmotiv = CreateObjectSet(Of vi_aipinssusmotiv)("vi_aipinssusmotiv")
            _vi_aipinssusrepuest = CreateObjectSet(Of vi_aipinssusrepuest)("vi_aipinssusrepuest")
            _vi_aipinssussse = CreateObjectSet(Of vi_aipinssussse)("vi_aipinssussse")
            _vi_aipinssusssm = CreateObjectSet(Of vi_aipinssusssm)("vi_aipinssusssm")
            _vi_aipactivperi = CreateObjectSet(Of vi_aipactivperi)("vi_aipactivperi")
            _vi_aipactivperidet = CreateObjectSet(Of vi_aipactivperidet)("vi_aipactivperidet")
            _vi_aipinsajussinmobragrup = CreateObjectSet(Of vi_aipinsajussinmobragrup)("vi_aipinsajussinmobragrup")
            _vi_aipinsajusanexmobragrup = CreateObjectSet(Of vi_aipinsajusanexmobragrup)("vi_aipinsajusanexmobragrup")

            _vi_aipinsdistperit = CreateObjectSet(Of vi_aipinsdistperit)("vi_aipinsdistperit")
            _vi_aipinsdistperitperf = CreateObjectSet(Of vi_aipinsdistperitperf)("vi_aipinsdistperitperf")
            _vi_aipinsdistaudit = CreateObjectSet(Of vi_aipinsdistaudit)("vi_aipinsdistaudit")
            _vi_aipinsdistauditperf = CreateObjectSet(Of vi_aipinsdistauditperf)("vi_aipinsdistauditperf")

            _vi_aipinsdistperitdet = CreateObjectSet(Of vi_aipinsdistperitdet)("vi_aipinsdistperitdet")
            _vi_aipinsdistauditdet = CreateObjectSet(Of vi_aipinsdistauditdet)("vi_aipinsdistauditdet")

            _vi_aipinsencdet = CreateObjectSet(Of vi_aipinsencdet)("vi_aipinsencdet")

            _vi_aipinssinrepu = CreateObjectSet(Of vi_aipinssinrepu)("vi_aipinssinrepu")
            _vi_aipinssin = CreateObjectSet(Of vi_aipinssin)("vi_aipinssin")
            _vi_aipinssinmobr = CreateObjectSet(Of vi_aipinssinmobr)("vi_aipinssinmobr")

            _vi_aipinssinmotiv = CreateObjectSet(Of vi_aipinssinmotiv)("vi_aipinssinmotiv")
            _vi_aipinssusinfcomp = CreateObjectSet(Of vi_aipinssusinfcomp)("vi_aipinssusinfcomp")

            _vi_aipinsperitagrup = CreateObjectSet(Of vi_aipinsperitagrup)("vi_aipinsperitagrup")
            _vi_aipinsauditagrup = CreateObjectSet(Of vi_aipinsauditagrup)("vi_aipinsauditagrup")

            _vi_intermediacion = CreateObjectSet(Of vi_intermediacion)("vi_intermediacion")
            _vi_aipextsintagenda = CreateObjectSet(Of vi_aipextsintagenda)("vi_aipextsintagenda")


            '------fin inspeccion
            '        
            '------log            
            _aiplogeve = CreateObjectSet(Of aiplogeve)("aiplogeve")
            '-----vistas
            _vi_aiplogeve = CreateObjectSet(Of vi_aiplogeve)("vi_aiplogeve")
            '------fin log
            '
            '------mantenimiento            
            _aipmandisp = CreateObjectSet(Of aipmandisp)("aipmandisp")
            _aipmanrepu = CreateObjectSet(Of aipmanrepu)("aipmanrepu")
            _aipmanveh = CreateObjectSet(Of aipmanveh)("aipmanveh")
            _aipmanvehacc = CreateObjectSet(Of aipmanvehacc)("aipmanvehacc")
            _aipmanvehmar = CreateObjectSet(Of aipmanvehmar)("aipmanvehmar")
            _aipmanvehmod = CreateObjectSet(Of aipmanvehmod)("aipmanvehmod")
            _aipmanvehsse = CreateObjectSet(Of aipmanvehsse)("aipmanvehsse")
            _aipmanvehssm = CreateObjectSet(Of aipmanvehssm)("aipmanvehssm")
            _aipmanvehver = CreateObjectSet(Of aipmanvehver)("aipmanvehver")
            _aipmaninfcomp = CreateObjectSet(Of aipmaninfcomp)("aipmaninfcomp")
            _aipinssusinfcomp = CreateObjectSet(Of aipinssusinfcomp)("aipinssusinfcomp")

            '-------vistas
            '_vi_aipmandisp = CreateObjectSet(Of vi_aipmandisp)("vi_aipmandisp")
            _vi_aipmanrepu = CreateObjectSet(Of vi_aipmanrepu)("vi_aipmanrepu")
            _vi_aipmanveh = CreateObjectSet(Of vi_aipmanveh)("vi_aipmanveh")
            _vi_aipmanvehmod = CreateObjectSet(Of vi_aipmanvehmod)("vi_aipmanvehmod")
            _vi_aipmanvehver = CreateObjectSet(Of vi_aipmanvehver)("vi_aipmanvehver")
            '_vi_aipmanvehacc = CreateObjectSet(Of vi_aipmanvehacc)("vi_aipmanvehacc")
            '_vi_aipmanvehmar = CreateObjectSet(Of vi_aipmanvehmar)("vi_aipmanvehmar")
            '_vi_aipmanvehmod = CreateObjectSet(Of vi_aipmanvehmod)("vi_aipmanvehmod")
            '_vi_aipmanvehsse = CreateObjectSet(Of vi_aipmanvehsse)("vi_aipmanvehsse")
            '_vi_aipmanvehssm = CreateObjectSet(Of vi_aipmanvehssm)("vi_aipmanvehssm")
            '_vi_aipmanvehver = CreateObjectSet(Of vi_aipmanvehver)("vi_aipmanvehver")
            '
            '------fin mantenimiento

            '------usuario
            '            
            _aipusudisp = CreateObjectSet(Of aipusudisp)("aipusudisp")
            _vi_aipusudisp = CreateObjectSet(Of vi_aipusudisp)("vi_aipusudisp")

            _aipmanusuconf = CreateObjectSet(Of aipmanusuconf)("aipmanusuconf")
            _vi_aipmanusuconf = CreateObjectSet(Of vi_aipmanusuconf)("vi_aipmanusuconf")
            _vi_aipmanusuconfperf = CreateObjectSet(Of vi_aipmanusuconfperf)("vi_aipmanusuconfperf")

            '------fin usuario
            '
            '--fin aipiauto
            _aipgenobj = CreateObjectSet(Of aipgenobj)("aipgenobj")
            'aipgenobj
        End Sub

        Public Sub New(ec As EntityClient.EntityConnection)
            MyBase.New(ec, "cnxdbestarseguros20" & ConfigurationManager.AppSettings("motoddb"))
            ContextOptions.LazyLoadingEnabled = False
            ContextOptions.ProxyCreationEnabled = False

            _segmanusu = CreateObjectSet(Of segmanusu)("segmanusu")
            _segmancarg = CreateObjectSet(Of segmancarg)("segmancarg")
            _segmandep = CreateObjectSet(Of segmandep)("segmandep")

            _seglogerr = CreateObjectSet(Of seglogerr)("seglogerr")

            _vi_segmanusu = CreateObjectSet(Of vi_segmanusu)("vi_segmanusu")
            _vi_segusuperf = CreateObjectSet(Of vi_segusuperf)("vi_segusuperf")
            _vi_segappprog = CreateObjectSet(Of vi_segappprog)("vi_segappprog")
            _vi_segaccperf = CreateObjectSet(Of vi_segaccperf)("vi_segaccperf")
            _vi_segusudetperf2 = CreateObjectSet(Of vi_segusudetperf2)("vi_segusudetperf2")
            _vi_segappperf = CreateObjectSet(Of vi_segappperf)("vi_segappperf")
            _vi_combosegmanorg = CreateObjectSet(Of vi_combosegmanorg)("vi_combosegmanorg")

            '-- comun
            _comunconfcontad = CreateObjectSet(Of comunconfcontad)("comunconfcontad")
            _comunconfsmtp = CreateObjectSet(Of comunconfsmtp)("comunconfsmtp")
            _comunconfvalor = CreateObjectSet(Of comunconfvalor)("comunconfvalor")
            _comunmancom = CreateObjectSet(Of comunmancom)("comunmancom")
            _comunmancont = CreateObjectSet(Of comunmancont)("comunmancont")
            _comunmandir = CreateObjectSet(Of comunmandir)("comunmandir")
            _comunmanempr = CreateObjectSet(Of comunmanempr)("comunmanempr")
            _comunmanestado = CreateObjectSet(Of comunmanestado)("comunmanestado")
            _comunmanlocalid = CreateObjectSet(Of comunmanlocalid)("comunmanlocalid")
            _comunmanpais = CreateObjectSet(Of comunmanpais)("comunmanpais")
            _comunmanpers = CreateObjectSet(Of comunmanpers)("comunmanpers")
            '--fin comun

            '--aipiauto
            '
            '------baremos
            _aipbaremobr = CreateObjectSet(Of aipbaremobr)("aipbaremobr")
            _aipbarerepu = CreateObjectSet(Of aipbarerepu)("aipbarerepu")
            '-------vistas
            _vi_aipbaremobr = CreateObjectSet(Of vi_aipbaremobr)("vi_aipbaremobr")
            _vi_aipbarerepu = CreateObjectSet(Of vi_aipbarerepu)("vi_aipbarerepu")
            _vi_comboaipbarerepuorig = CreateObjectSet(Of vi_comboaipbarerepuorig)("vi_comboaipbarerepuorig")
            _vi_comboaipbaremobrtama = CreateObjectSet(Of vi_comboaipbaremobrtama)("vi_comboaipbaremobrtama")
            _vi_comboaipbaremobrmater = CreateObjectSet(Of vi_comboaipbaremobrmater)("vi_comboaipbaremobrmater")
            _vi_comboaipbaremobrmobr = CreateObjectSet(Of vi_comboaipbaremobrmobr)("vi_comboaipbaremobrmobr")
            '------fin baremos
            'agenda
            _aipactivperi = CreateObjectSet(Of aipactivperi)("aipactivperi")
            '
            '------inspeccion
            _aipinsajusanex = CreateObjectSet(Of aipinsajusanex)("aipinsajusanex")
            _aipinsajusanexmobr = CreateObjectSet(Of aipinsajusanexmobr)("aipinsajusanexmobr")
            _aipinsajusanexrepu = CreateObjectSet(Of aipinsajusanexrepu)("aipinsajusanexrepu")
            _aipinsajussin = CreateObjectSet(Of aipinsajussin)("aipinsajussin")
            _aipinsajussinmobr = CreateObjectSet(Of aipinsajussinmobr)("aipinsajussinmobr")
            _aipinsajussinrepu = CreateObjectSet(Of aipinsajussinrepu)("aipinsajussinrepu")
            _aipinsenc = CreateObjectSet(Of aipinsenc)("aipinsenc")
            _aipinsfoto = CreateObjectSet(Of aipinsfoto)("aipinsfoto")
            _aipinsarch = CreateObjectSet(Of aipinsarch)("aipinsarch")
            _aipinslimsin = CreateObjectSet(Of aipinslimsin)("aipinslimsin")
            _aipinslimsinmobr = CreateObjectSet(Of aipinslimsinmobr)("aipinslimsinmobr")
            _aipinslimsinrepu = CreateObjectSet(Of aipinslimsinrepu)("aipinslimsinrepu")
            _aipinslimsus = CreateObjectSet(Of aipinslimsus)("aipinslimsus")
            _aipinslimsusmobr = CreateObjectSet(Of aipinslimsusmobr)("aipinslimsusmobr")
            _aipinslimsusrepu = CreateObjectSet(Of aipinslimsusrepu)("aipinslimsusrepu")
            _aipinsmotiv = CreateObjectSet(Of aipinsmotiv)("aipinsmotiv")
            _aipinsrest = CreateObjectSet(Of aipinsrest)("aipinsrest")
            _aipinsrestrepuest = CreateObjectSet(Of aipinsrestrepuest)("aipinsrestrepuest")
            _aipinsrestsse = CreateObjectSet(Of aipinsrestsse)("aipinsrestsse")
            _aipinsrestssm = CreateObjectSet(Of aipinsrestssm)("aipinsrestssm")
            _aipinssus = CreateObjectSet(Of aipinssus)("aipinssus")
            _aipinssusacc = CreateObjectSet(Of aipinssusacc)("aipinssusacc")
            _aipinssusmotiv = CreateObjectSet(Of aipinssusmotiv)("aipinssusmotiv")
            _aipinssusrepuest = CreateObjectSet(Of aipinssusrepuest)("aipinssusrepuest")
            _aipinssussse = CreateObjectSet(Of aipinssussse)("aipinssussse")
            _aipinssusssm = CreateObjectSet(Of aipinssusssm)("aipinssusssm")

            _aipinssinrepu = CreateObjectSet(Of aipinssinrepu)("aipinssinrepu")
            _aipinssin = CreateObjectSet(Of aipinssin)("aipinssin")
            _aipinssinmobr = CreateObjectSet(Of aipinssinmobr)("aipinssinmobr")

            _aipinssinmotiv = CreateObjectSet(Of aipinssinmotiv)("aipinssinmotiv")


            '----------vistas
            _vi_aipinsajusanex = CreateObjectSet(Of vi_aipinsajusanex)("vi_aipinsajusanex")
            _vi_aipinsajusanexmobr = CreateObjectSet(Of vi_aipinsajusanexmobr)("vi_aipinsajusanexmobr")
            _vi_aipinsajusanexrepu = CreateObjectSet(Of vi_aipinsajusanexrepu)("vi_aipinsajusanexrepu")
            _vi_aipinsajussin = CreateObjectSet(Of vi_aipinsajussin)("vi_aipinsajussin")
            _vi_aipinsajussinmobr = CreateObjectSet(Of vi_aipinsajussinmobr)("vi_aipinsajussinmobr")
            _vi_aipinsajussinrepu = CreateObjectSet(Of vi_aipinsajussinrepu)("vi_aipinsajussinrepu")
            _vi_aipinsenc = CreateObjectSet(Of vi_aipinsenc)("vi_aipinsenc")
            _vi_aipinsfoto = CreateObjectSet(Of vi_aipinsfoto)("vi_aipinsfoto")
            _vi_aipinsarch = CreateObjectSet(Of vi_aipinsarch)("vi_aipinsarch")

            _vi_aipinslimsinmobr = CreateObjectSet(Of vi_aipinslimsinmobr)("vi_aipinslimsinmobr")
            _vi_aipinslimsinrepu = CreateObjectSet(Of vi_aipinslimsinrepu)("vi_aipinslimsinrepu")
            _vi_aipinslimsus = CreateObjectSet(Of vi_aipinslimsus)("vi_aipinslimsus")
            _vi_aipinslimsusmobr = CreateObjectSet(Of vi_aipinslimsusmobr)("vi_aipinslimsusmobr")
            _vi_aipinslimsusrepu = CreateObjectSet(Of vi_aipinslimsusrepu)("vi_aipinslimsusrepu")
            '_vi_aipinsmotiv = CreateObjectSet(Of vi_aipinsmotiv)("vi_aipinsmotiv")
            _vi_aipinsrest = CreateObjectSet(Of vi_aipinsrest)("vi_aipinsrest")
            _vi_aipinsrestrepuest = CreateObjectSet(Of vi_aipinsrestrepuest)("vi_aipinsrestrepuest")
            _vi_aipinsrestsse = CreateObjectSet(Of vi_aipinsrestsse)("vi_aipinsrestsse")
            _vi_aipinsrestssm = CreateObjectSet(Of vi_aipinsrestssm)("vi_aipinsrestssm")
            _vi_aipinssus = CreateObjectSet(Of vi_aipinssus)("vi_aipinssus")
            _vi_aipinssusacc = CreateObjectSet(Of vi_aipinssusacc)("vi_aipinssusacc")
            _vi_aipinssusmotiv = CreateObjectSet(Of vi_aipinssusmotiv)("vi_aipinssusmotiv")
            _vi_aipinssusrepuest = CreateObjectSet(Of vi_aipinssusrepuest)("vi_aipinssusrepuest")
            _vi_aipinssussse = CreateObjectSet(Of vi_aipinssussse)("vi_aipinssussse")
            _vi_aipinssusssm = CreateObjectSet(Of vi_aipinssusssm)("vi_aipinssusssm")
            _vi_aipactivperi = CreateObjectSet(Of vi_aipactivperi)("vi_aipactivperi")
            _vi_aipactivperidet = CreateObjectSet(Of vi_aipactivperidet)("vi_aipactivperidet")
            _vi_aipinsajussinmobragrup = CreateObjectSet(Of vi_aipinsajussinmobragrup)("vi_aipinsajussinmobragrup")
            _vi_aipinsajusanexmobragrup = CreateObjectSet(Of vi_aipinsajusanexmobragrup)("vi_aipinsajusanexmobragrup")

            _vi_aipinsdistperit = CreateObjectSet(Of vi_aipinsdistperit)("vi_aipinsdistperit")
            _vi_aipinsdistperitperf = CreateObjectSet(Of vi_aipinsdistperitperf)("vi_aipinsdistperitperf")
            _vi_aipinsdistaudit = CreateObjectSet(Of vi_aipinsdistaudit)("vi_aipinsdistaudit")
            _vi_aipinsdistauditperf = CreateObjectSet(Of vi_aipinsdistauditperf)("vi_aipinsdistauditperf")

            _vi_aipinsdistperitdet = CreateObjectSet(Of vi_aipinsdistperitdet)("vi_aipinsdistperitdet")
            _vi_aipinsdistauditdet = CreateObjectSet(Of vi_aipinsdistauditdet)("vi_aipinsdistauditdet")

            _vi_aipinsencdet = CreateObjectSet(Of vi_aipinsencdet)("vi_aipinsencdet")

            _vi_aipinssinrepu = CreateObjectSet(Of vi_aipinssinrepu)("vi_aipinssinrepu")
            _vi_aipinssin = CreateObjectSet(Of vi_aipinssin)("vi_aipinssin")
            _vi_aipinssinmobr = CreateObjectSet(Of vi_aipinssinmobr)("vi_aipinssinmobr")

            _vi_aipinssinmotiv = CreateObjectSet(Of vi_aipinssinmotiv)("vi_aipinssinmotiv")
            _vi_aipinssusinfcomp = CreateObjectSet(Of vi_aipinssusinfcomp)("vi_aipinssusinfcomp")


            _vi_aipinsperitagrup = CreateObjectSet(Of vi_aipinsperitagrup)("vi_aipinsperitagrup")
            _vi_aipinsauditagrup = CreateObjectSet(Of vi_aipinsauditagrup)("vi_aipinsauditagrup")

            _vi_intermediacion = CreateObjectSet(Of vi_intermediacion)("vi_intermediacion")
            _vi_aipextsintagenda = CreateObjectSet(Of vi_aipextsintagenda)("vi_aipextsintagenda")



            '------fin inspeccion
            '        
            '------log            
            _aiplogeve = CreateObjectSet(Of aiplogeve)("aiplogeve")
            '-----vistas
            _vi_aiplogeve = CreateObjectSet(Of vi_aiplogeve)("vi_aiplogeve")
            '------fin log
            '
            '------mantenimiento            
            _aipmandisp = CreateObjectSet(Of aipmandisp)("aipmandisp")
            _aipmanrepu = CreateObjectSet(Of aipmanrepu)("aipmanrepu")
            _aipmanveh = CreateObjectSet(Of aipmanveh)("aipmanveh")
            _aipmanvehacc = CreateObjectSet(Of aipmanvehacc)("aipmanvehacc")
            _aipmanvehmar = CreateObjectSet(Of aipmanvehmar)("aipmanvehmar")
            _aipmanvehmod = CreateObjectSet(Of aipmanvehmod)("aipmanvehmod")
            _aipmanvehsse = CreateObjectSet(Of aipmanvehsse)("aipmanvehsse")
            _aipmanvehssm = CreateObjectSet(Of aipmanvehssm)("aipmanvehssm")
            _aipmanvehver = CreateObjectSet(Of aipmanvehver)("aipmanvehver")
            _aipmaninfcomp = CreateObjectSet(Of aipmaninfcomp)("aipmaninfcomp")
            _aipinssusinfcomp = CreateObjectSet(Of aipinssusinfcomp)("aipinssusinfcomp")

            '-------vistas
            '_vi_aipmandisp = CreateObjectSet(Of vi_aipmandisp)("vi_aipmandisp")
            _vi_aipmanrepu = CreateObjectSet(Of vi_aipmanrepu)("vi_aipmanrepu")
            _vi_aipmanveh = CreateObjectSet(Of vi_aipmanveh)("vi_aipmanveh")
            _vi_aipmanvehmod = CreateObjectSet(Of vi_aipmanvehmod)("vi_aipmanvehmod")
            _vi_aipmanvehver = CreateObjectSet(Of vi_aipmanvehver)("vi_aipmanvehver")
            '_vi_aipmanvehacc = CreateObjectSet(Of vi_aipmanvehacc)("vi_aipmanvehacc")
            '_vi_aipmanvehmar = CreateObjectSet(Of vi_aipmanvehmar)("vi_aipmanvehmar")
            '_vi_aipmanvehmod = CreateObjectSet(Of vi_aipmanvehmod)("vi_aipmanvehmod")
            '_vi_aipmanvehsse = CreateObjectSet(Of vi_aipmanvehsse)("vi_aipmanvehsse")
            '_vi_aipmanvehssm = CreateObjectSet(Of vi_aipmanvehssm)("vi_aipmanvehssm")
            '_vi_aipmanvehver = CreateObjectSet(Of vi_aipmanvehver)("vi_aipmanvehver")
            '
            '------fin mantenimiento

            '------usuario
            '            
            _aipusudisp = CreateObjectSet(Of aipusudisp)("aipusudisp")
            _vi_aipusudisp = CreateObjectSet(Of vi_aipusudisp)("vi_aipusudisp")

            _aipmanusuconf = CreateObjectSet(Of aipmanusuconf)("aipmanusuconf")
            _vi_aipmanusuconf = CreateObjectSet(Of vi_aipmanusuconf)("vi_aipmanusuconf")
            _vi_aipmanusuconfperf = CreateObjectSet(Of vi_aipmanusuconfperf)("vi_aipmanusuconfperf")
            '------fin usuario
            '
            '--fin aipiauto
            _aipgenobj = CreateObjectSet(Of aipgenobj)("aipgenobj")
            '
        End Sub
#End Region

#Region "propiedades"
        Public ReadOnly Property segmanusu() As ObjectSet(Of segmanusu)
            Get
                Return _segmanusu
            End Get
        End Property

        Public ReadOnly Property segmancarg() As ObjectSet(Of segmancarg)
            Get
                Return _segmancarg
            End Get
        End Property

        Public ReadOnly Property segmandep() As ObjectSet(Of segmandep)
            Get
                Return _segmandep
            End Get
        End Property

        Public ReadOnly Property seglogerr() As ObjectSet(Of seglogerr)
            Get
                Return _seglogerr
            End Get
        End Property

        Public ReadOnly Property vi_segmanusu() As ObjectSet(Of vi_segmanusu)
            Get
                Return _vi_segmanusu
            End Get
        End Property

        Public ReadOnly Property vi_segusuperf() As ObjectSet(Of vi_segusuperf)
            Get
                Return _vi_segusuperf
            End Get
        End Property

        Public ReadOnly Property vi_segappprog() As ObjectSet(Of vi_segappprog)
            Get
                Return _vi_segappprog
            End Get
        End Property

        Public ReadOnly Property vi_segaccperf() As ObjectSet(Of vi_segaccperf)
            Get
                Return _vi_segaccperf
            End Get
        End Property

        Public ReadOnly Property vi_segusudetperf2() As ObjectSet(Of vi_segusudetperf2)
            Get
                Return _vi_segusudetperf2
            End Get
        End Property

        Public ReadOnly Property vi_segappperf() As ObjectSet(Of vi_segappperf)
            Get
                Return _vi_segappperf
            End Get
        End Property

        Public ReadOnly Property vi_combosegmanorg() As ObjectSet(Of vi_combosegmanorg)
            Get
                Return _vi_combosegmanorg
            End Get
        End Property

        '-- comun
        Public ReadOnly Property comunconfcontad() As ObjectSet(Of comunconfcontad)
            Get
                Return _comunconfcontad
            End Get
        End Property
        Public ReadOnly Property comunconfsmtp() As ObjectSet(Of comunconfsmtp)
            Get
                Return _comunconfsmtp
            End Get
        End Property
        Public ReadOnly Property comunconfvalor() As ObjectSet(Of comunconfvalor)
            Get
                Return _comunconfvalor
            End Get
        End Property
        Public ReadOnly Property comunmancom() As ObjectSet(Of comunmancom)
            Get
                Return _comunmancom
            End Get
        End Property
        Public ReadOnly Property comunmancont() As ObjectSet(Of comunmancont)
            Get
                Return _comunmancont
            End Get
        End Property
        Public ReadOnly Property comunmandir() As ObjectSet(Of comunmandir)
            Get
                Return _comunmandir
            End Get
        End Property
        Public ReadOnly Property comunmanempr() As ObjectSet(Of comunmanempr)
            Get
                Return _comunmanempr
            End Get
        End Property
        Public ReadOnly Property comunmanestado() As ObjectSet(Of comunmanestado)
            Get
                Return _comunmanestado
            End Get
        End Property

        Public ReadOnly Property comunmanlocalid() As ObjectSet(Of comunmanlocalid)
            Get
                Return _comunmanlocalid
            End Get
        End Property

        Public ReadOnly Property comunmanpais() As ObjectSet(Of comunmanpais)
            Get
                Return _comunmanpais
            End Get
        End Property

        Public ReadOnly Property comunmanpers() As ObjectSet(Of comunmanpers)
            Get
                Return _comunmanpers
            End Get
        End Property
        '--fin comun

        '--aipiauto
        '
        '------baremos
        Public ReadOnly Property aipbaremobr() As ObjectSet(Of aipbaremobr)
            Get
                Return _aipbaremobr
            End Get
        End Property

        Public ReadOnly Property aipbarerepu() As ObjectSet(Of aipbarerepu)
            Get
                Return _aipbarerepu
            End Get
        End Property
        '-------vistas
        Public ReadOnly Property vi_aipbaremobr() As ObjectSet(Of vi_aipbaremobr)
            Get
                Return _vi_aipbaremobr
            End Get
        End Property

        Public ReadOnly Property vi_aipbarerepu() As ObjectSet(Of vi_aipbarerepu)
            Get
                Return _vi_aipbarerepu
            End Get
        End Property


        Public ReadOnly Property vi_comboaipbarerepuorig() As ObjectSet(Of vi_comboaipbarerepuorig)
            Get
                Return _vi_comboaipbarerepuorig
            End Get
        End Property

        Public ReadOnly Property vi_comboaipbaremobrtama() As ObjectSet(Of vi_comboaipbaremobrtama)
            Get
                Return _vi_comboaipbaremobrtama
            End Get
        End Property

        Public ReadOnly Property vi_comboaipbaremobrmater() As ObjectSet(Of vi_comboaipbaremobrmater)
            Get
                Return _vi_comboaipbaremobrmater
            End Get
        End Property

        Public ReadOnly Property vi_comboaipbaremobrmobr() As ObjectSet(Of vi_comboaipbaremobrmobr)
            Get
                Return _vi_comboaipbaremobrmobr
            End Get
        End Property

        '------fin baremos
        'agenda
        Public ReadOnly Property aipactivperi() As ObjectSet(Of aipactivperi)
            Get
                Return _aipactivperi
            End Get
        End Property
        '
        '------inspeccion            
        Public ReadOnly Property aipinsajusanex() As ObjectSet(Of aipinsajusanex)
            Get
                Return _aipinsajusanex
            End Get
        End Property

        Public ReadOnly Property aipinsajusanexmobr() As ObjectSet(Of aipinsajusanexmobr)
            Get
                Return _aipinsajusanexmobr
            End Get
        End Property

        Public ReadOnly Property aipinsajusanexrepu() As ObjectSet(Of aipinsajusanexrepu)
            Get
                Return _aipinsajusanexrepu
            End Get
        End Property

        Public ReadOnly Property aipinsajussin() As ObjectSet(Of aipinsajussin)
            Get
                Return _aipinsajussin
            End Get
        End Property

        Public ReadOnly Property aipinsajussinmobr() As ObjectSet(Of aipinsajussinmobr)
            Get
                Return _aipinsajussinmobr
            End Get
        End Property

        Public ReadOnly Property aipinsajussinrepu() As ObjectSet(Of aipinsajussinrepu)
            Get
                Return _aipinsajussinrepu
            End Get
        End Property

        Public ReadOnly Property aipinsenc() As ObjectSet(Of aipinsenc)
            Get
                Return _aipinsenc
            End Get
        End Property

        Public ReadOnly Property aipinsfoto() As ObjectSet(Of aipinsfoto)
            Get
                Return _aipinsfoto
            End Get
        End Property

        Public ReadOnly Property aipinsarch() As ObjectSet(Of aipinsarch)
            Get
                Return _aipinsarch
            End Get
        End Property

        Public ReadOnly Property aipinslimsin() As ObjectSet(Of aipinslimsin)
            Get
                Return _aipinslimsin
            End Get
        End Property

        Public ReadOnly Property aipinslimsinmobr() As ObjectSet(Of aipinslimsinmobr)
            Get
                Return _aipinslimsinmobr
            End Get
        End Property

        Public ReadOnly Property aipinslimsinrepu() As ObjectSet(Of aipinslimsinrepu)
            Get
                Return _aipinslimsinrepu
            End Get
        End Property

        Public ReadOnly Property aipinslimsus() As ObjectSet(Of aipinslimsus)
            Get
                Return _aipinslimsus
            End Get
        End Property

        Public ReadOnly Property aipinslimsusmobr() As ObjectSet(Of aipinslimsusmobr)
            Get
                Return _aipinslimsusmobr
            End Get
        End Property

        Public ReadOnly Property aipinslimsusrepu() As ObjectSet(Of aipinslimsusrepu)
            Get
                Return _aipinslimsusrepu
            End Get
        End Property

        Public ReadOnly Property aipinsmotiv() As ObjectSet(Of aipinsmotiv)
            Get
                Return _aipinsmotiv
            End Get
        End Property

        Public ReadOnly Property aipinsrest() As ObjectSet(Of aipinsrest)
            Get
                Return _aipinsrest
            End Get
        End Property

        Public ReadOnly Property aipinsrestrepuest() As ObjectSet(Of aipinsrestrepuest)
            Get
                Return _aipinsrestrepuest
            End Get
        End Property

        Public ReadOnly Property aipinsrestsse() As ObjectSet(Of aipinsrestsse)
            Get
                Return _aipinsrestsse
            End Get
        End Property

        Public ReadOnly Property aipinsrestssm() As ObjectSet(Of aipinsrestssm)
            Get
                Return _aipinsrestssm
            End Get
        End Property

        Public ReadOnly Property aipinssus() As ObjectSet(Of aipinssus)
            Get
                Return _aipinssus
            End Get
        End Property

        Public ReadOnly Property aipinssusacc() As ObjectSet(Of aipinssusacc)
            Get
                Return _aipinssusacc
            End Get
        End Property

        Public ReadOnly Property aipinssusmotiv() As ObjectSet(Of aipinssusmotiv)
            Get
                Return _aipinssusmotiv
            End Get
        End Property

        Public ReadOnly Property aipinssusrepuest() As ObjectSet(Of aipinssusrepuest)
            Get
                Return _aipinssusrepuest
            End Get
        End Property

        Public ReadOnly Property aipinssussse() As ObjectSet(Of aipinssussse)
            Get
                Return _aipinssussse
            End Get
        End Property

        Public ReadOnly Property aipinssusssm() As ObjectSet(Of aipinssusssm)
            Get
                Return _aipinssusssm
            End Get
        End Property

        Public ReadOnly Property aipmaninfcomp() As ObjectSet(Of aipmaninfcomp)
            Get
                Return _aipmaninfcomp
            End Get
        End Property

        Public ReadOnly Property aipinssusinfcomp() As ObjectSet(Of aipinssusinfcomp)
            Get
                Return _aipinssusinfcomp
            End Get
        End Property


        Public ReadOnly Property aipinssinrepu() As ObjectSet(Of aipinssinrepu)
            Get
                Return _aipinssinrepu
            End Get
        End Property

        Public ReadOnly Property aipinssin() As ObjectSet(Of aipinssin)
            Get
                Return _aipinssin
            End Get
        End Property

        Public ReadOnly Property aipinssinmobr() As ObjectSet(Of aipinssinmobr)
            Get
                Return _aipinssinmobr
            End Get
        End Property


        Public ReadOnly Property aipinssinmotiv() As ObjectSet(Of aipinssinmotiv)
            Get
                Return _aipinssinmotiv
            End Get
        End Property




        'vistas
        Public ReadOnly Property vi_aipinsajusanex() As ObjectSet(Of vi_aipinsajusanex)
            Get
                Return _vi_aipinsajusanex
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajusanexmobr() As ObjectSet(Of vi_aipinsajusanexmobr)
            Get
                Return _vi_aipinsajusanexmobr
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajusanexrepu() As ObjectSet(Of vi_aipinsajusanexrepu)
            Get
                Return _vi_aipinsajusanexrepu
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajussin() As ObjectSet(Of vi_aipinsajussin)
            Get
                Return _vi_aipinsajussin
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajussinmobr() As ObjectSet(Of vi_aipinsajussinmobr)
            Get
                Return _vi_aipinsajussinmobr
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajussinrepu() As ObjectSet(Of vi_aipinsajussinrepu)
            Get
                Return _vi_aipinsajussinrepu
            End Get
        End Property

        Public ReadOnly Property vi_aipinsenc() As ObjectSet(Of vi_aipinsenc)
            Get
                Return _vi_aipinsenc
            End Get
        End Property

        Public ReadOnly Property vi_aipinsfoto() As ObjectSet(Of vi_aipinsfoto)
            Get
                Return _vi_aipinsfoto
            End Get
        End Property

        Public ReadOnly Property vi_aipinsarch() As ObjectSet(Of vi_aipinsarch)
            Get
                Return _vi_aipinsarch
            End Get
        End Property

        Public ReadOnly Property vi_aipinslimsin() As ObjectSet(Of vi_aipinslimsin)
            Get
                Return _vi_aipinslimsin
            End Get
        End Property

        Public ReadOnly Property vi_aipinslimsinmobr() As ObjectSet(Of vi_aipinslimsinmobr)
            Get
                Return _vi_aipinslimsinmobr
            End Get
        End Property

        Public ReadOnly Property vi_aipinslimsinrepu() As ObjectSet(Of vi_aipinslimsinrepu)
            Get
                Return _vi_aipinslimsinrepu
            End Get
        End Property

        Public ReadOnly Property vi_aipinslimsus() As ObjectSet(Of vi_aipinslimsus)
            Get
                Return _vi_aipinslimsus
            End Get
        End Property

        Public ReadOnly Property vi_aipinslimsusmobr() As ObjectSet(Of vi_aipinslimsusmobr)
            Get
                Return _vi_aipinslimsusmobr
            End Get
        End Property

        Public ReadOnly Property vi_aipinslimsusrepu() As ObjectSet(Of vi_aipinslimsusrepu)
            Get
                Return _vi_aipinslimsusrepu
            End Get
        End Property

        'Public ReadOnly Property vi_aipinsmotiv() As ObjectSet(Of vi_aipinsmotiv)
        '    Get
        '        Return _vi_aipinsmotiv
        '    End Get
        'End Property

        Public ReadOnly Property vi_aipinsrest() As ObjectSet(Of vi_aipinsrest)
            Get
                Return _vi_aipinsrest
            End Get
        End Property

        Public ReadOnly Property vi_aipinsrestrepuest() As ObjectSet(Of vi_aipinsrestrepuest)
            Get
                Return _vi_aipinsrestrepuest
            End Get
        End Property

        Public ReadOnly Property vi_aipinsrestsse() As ObjectSet(Of vi_aipinsrestsse)
            Get
                Return _vi_aipinsrestsse
            End Get
        End Property

        Public ReadOnly Property vi_aipinsrestssm() As ObjectSet(Of vi_aipinsrestssm)
            Get
                Return _vi_aipinsrestssm
            End Get
        End Property

        Public ReadOnly Property vi_aipinssus() As ObjectSet(Of vi_aipinssus)
            Get
                Return _vi_aipinssus
            End Get
        End Property

        Public ReadOnly Property vi_aipinssusacc() As ObjectSet(Of vi_aipinssusacc)
            Get
                Return _vi_aipinssusacc
            End Get
        End Property

        Public ReadOnly Property vi_aipinssusmotiv() As ObjectSet(Of vi_aipinssusmotiv)
            Get
                Return _vi_aipinssusmotiv
            End Get
        End Property

        Public ReadOnly Property vi_aipinssusrepuest() As ObjectSet(Of vi_aipinssusrepuest)
            Get
                Return _vi_aipinssusrepuest
            End Get
        End Property

        Public ReadOnly Property vi_aipinssussse() As ObjectSet(Of vi_aipinssussse)
            Get
                Return _vi_aipinssussse
            End Get
        End Property

        Public ReadOnly Property vi_aipinssusssm() As ObjectSet(Of vi_aipinssusssm)
            Get
                Return _vi_aipinssusssm
            End Get
        End Property

        Public ReadOnly Property vi_aipactivperi() As ObjectSet(Of vi_aipactivperi)
            Get
                Return _vi_aipactivperi
            End Get
        End Property

        Public ReadOnly Property vi_aipactivperidet() As ObjectSet(Of vi_aipactivperidet)
            Get
                Return _vi_aipactivperidet
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajussinmobragrup() As ObjectSet(Of vi_aipinsajussinmobragrup)
            Get
                Return _vi_aipinsajussinmobragrup
            End Get
        End Property

        Public ReadOnly Property vi_aipinsajusanexmobragrup() As ObjectSet(Of vi_aipinsajusanexmobragrup)
            Get
                Return _vi_aipinsajusanexmobragrup
            End Get
        End Property

        Public ReadOnly Property vi_aipinsencdet() As ObjectSet(Of vi_aipinsencdet)
            Get
                Return _vi_aipinsencdet
            End Get
        End Property

        Public ReadOnly Property vi_aipinssinrepu() As ObjectSet(Of vi_aipinssinrepu)
            Get
                Return _vi_aipinssinrepu
            End Get
        End Property

        Public ReadOnly Property vi_aipinssin() As ObjectSet(Of vi_aipinssin)
            Get
                Return _vi_aipinssin
            End Get
        End Property

        Public ReadOnly Property vi_aipinssinmobr() As ObjectSet(Of vi_aipinssinmobr)
            Get
                Return _vi_aipinssinmobr
            End Get
        End Property

        Public ReadOnly Property vi_aipinssinmotiv() As ObjectSet(Of vi_aipinssinmotiv)
            Get
                Return _vi_aipinssinmotiv
            End Get
        End Property

        '------fin inspeccion
        '        
        '------log            

        Public ReadOnly Property aiplogeve() As ObjectSet(Of aiplogeve)
            Get
                Return _aiplogeve
            End Get
        End Property
        '--------vistas

        Public ReadOnly Property vi_aiplogeve() As ObjectSet(Of vi_aiplogeve)
            Get
                Return _vi_aiplogeve
            End Get
        End Property
        '------fin log
        '
        '------mantenimiento            

        Public ReadOnly Property aipmandisp() As ObjectSet(Of aipmandisp)
            Get
                Return _aipmandisp
            End Get
        End Property

        Public ReadOnly Property aipmanrepu() As ObjectSet(Of aipmanrepu)
            Get
                Return _aipmanrepu
            End Get
        End Property

        Public ReadOnly Property aipmanveh() As ObjectSet(Of aipmanveh)
            Get
                Return _aipmanveh
            End Get
        End Property

        Public ReadOnly Property aipmanvehacc() As ObjectSet(Of aipmanvehacc)
            Get
                Return _aipmanvehacc
            End Get
        End Property

        Public ReadOnly Property aipmanvehmar() As ObjectSet(Of aipmanvehmar)
            Get
                Return _aipmanvehmar
            End Get
        End Property

        Public ReadOnly Property aipmanvehmod() As ObjectSet(Of aipmanvehmod)
            Get
                Return _aipmanvehmod
            End Get
        End Property

        Public ReadOnly Property aipmanvehsse() As ObjectSet(Of aipmanvehsse)
            Get
                Return _aipmanvehsse
            End Get
        End Property

        Public ReadOnly Property aipmanvehssm() As ObjectSet(Of aipmanvehssm)
            Get
                Return _aipmanvehssm
            End Get
        End Property

        Public ReadOnly Property aipmanvehver() As ObjectSet(Of aipmanvehver)
            Get
                Return _aipmanvehver
            End Get
        End Property
        '-------vistas
        'Public ReadOnly Property vi_aipmandisp() As ObjectSet(Of vi_aipmandisp)
        '    Get
        '        Return _vi_aipmandisp
        '    End Get
        'End Property

        Public ReadOnly Property vi_aipmanrepu() As ObjectSet(Of vi_aipmanrepu)
            Get
                Return _vi_aipmanrepu
            End Get
        End Property

        Public ReadOnly Property vi_aipmanveh() As ObjectSet(Of vi_aipmanveh)
            Get
                Return _vi_aipmanveh
            End Get
        End Property

        Public ReadOnly Property vi_aipmanvehmod() As ObjectSet(Of vi_aipmanvehmod)
            Get
                Return _vi_aipmanvehmod
            End Get
        End Property

        Public ReadOnly Property vi_aipmanvehver() As ObjectSet(Of vi_aipmanvehver)
            Get
                Return _vi_aipmanvehver
            End Get
        End Property

        'Public ReadOnly Property vi_aipmanvehacc() As ObjectSet(Of vi_aipmanvehacc)
        '    Get
        '        Return _vi_aipmanvehacc
        '    End Get
        'End Property

        'Public ReadOnly Property vi_aipmanvehmar() As ObjectSet(Of vi_aipmanvehmar)
        '    Get
        '        Return _vi_aipmanvehmar
        '    End Get
        'End Property

        'Public ReadOnly Property vi_aipmanvehmod() As ObjectSet(Of vi_aipmanvehmod)
        '    Get
        '        Return _vi_aipmanvehmod
        '    End Get
        'End Property

        'Public ReadOnly Property vi_aipmanvehsse() As ObjectSet(Of vi_aipmanvehsse)
        '    Get
        '        Return _vi_aipmanvehsse
        '    End Get
        'End Property

        'Public ReadOnly Property vi_aipmanvehssm() As ObjectSet(Of vi_aipmanvehssm)
        '    Get
        '        Return _vi_aipmanvehssm
        '    End Get
        'End Property

        'Public ReadOnly Property vi_aipmanvehver() As ObjectSet(Of vi_aipmanvehver)
        '    Get
        '        Return _vi_aipmanvehver
        '    End Get
        'End Property
        '
        '------fin mantenimiento

        '------usuario
        '            
        Public ReadOnly Property aipusudisp() As ObjectSet(Of aipusudisp)
            Get
                Return _aipusudisp
            End Get
        End Property

        Public ReadOnly Property vi_aipusudisp() As ObjectSet(Of vi_aipusudisp)
            Get
                Return _vi_aipusudisp
            End Get
        End Property
        '------fin usuario


        Public ReadOnly Property vi_aipinsdistperit() As ObjectSet(Of vi_aipinsdistperit)
            Get
                Return _vi_aipinsdistperit
            End Get
        End Property

        Public ReadOnly Property vi_aipinsdistperitperf() As ObjectSet(Of vi_aipinsdistperitperf)
            Get
                Return _vi_aipinsdistperitperf
            End Get
        End Property

        Public ReadOnly Property vi_aipinsdistaudit() As ObjectSet(Of vi_aipinsdistaudit)
            Get
                Return _vi_aipinsdistaudit
            End Get
        End Property

        Public ReadOnly Property vi_aipinsdistauditperf() As ObjectSet(Of vi_aipinsdistauditperf)
            Get
                Return _vi_aipinsdistauditperf
            End Get
        End Property


        Public ReadOnly Property vi_aipinsdistperitdet() As ObjectSet(Of vi_aipinsdistperitdet)
            Get
                Return _vi_aipinsdistperitdet
            End Get
        End Property

        Public ReadOnly Property vi_aipinsdistauditdet() As ObjectSet(Of vi_aipinsdistauditdet)
            Get
                Return _vi_aipinsdistauditdet
            End Get
        End Property

        Public ReadOnly Property vi_aipinssusinfcomp() As ObjectSet(Of vi_aipinssusinfcomp)
            Get
                Return _vi_aipinssusinfcomp
            End Get
        End Property

        Public ReadOnly Property vi_aipinsperitagrup() As ObjectSet(Of vi_aipinsperitagrup)
            Get
                Return _vi_aipinsperitagrup
            End Get
        End Property

        Public ReadOnly Property vi_aipinsauditagrup() As ObjectSet(Of vi_aipinsauditagrup)
            Get
                Return _vi_aipinsauditagrup
            End Get
        End Property

        Public ReadOnly Property vi_intermediacion() As ObjectSet(Of vi_intermediacion)
            Get
                Return _vi_intermediacion
            End Get
        End Property

        Public ReadOnly Property vi_aipextsintagenda() As ObjectSet(Of vi_aipextsintagenda)
            Get
                Return _vi_aipextsintagenda
            End Get
        End Property

        Public ReadOnly Property aipmanusuconf() As ObjectSet(Of aipmanusuconf)
            Get
                Return _aipmanusuconf
            End Get
        End Property

        Public ReadOnly Property vi_aipmanusuconf() As ObjectSet(Of vi_aipmanusuconf)
            Get
                Return _vi_aipmanusuconf
            End Get
        End Property

        Public ReadOnly Property vi_aipmanusuconfperf() As ObjectSet(Of vi_aipmanusuconfperf)
            Get
                Return _vi_aipmanusuconfperf
            End Get
        End Property


        '
        '--fin aipiauto
        Public ReadOnly Property aipgenobj() As ObjectSet(Of aipgenobj)
            Get
                Return _aipgenobj
            End Get
        End Property
        'aipgenobj


#End Region

    End Class
End Namespace