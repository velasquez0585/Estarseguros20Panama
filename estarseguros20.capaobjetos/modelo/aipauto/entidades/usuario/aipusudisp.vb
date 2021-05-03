Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.usuario
Namespace aipauto.modelo.dbestarseguros20.entidades.usuario

	Public Class aipusudisp

		Private p_idaipusudisp As Decimal
		Private p_idsegmanusu As Decimal
		Private p_idaipmandisp As Decimal
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmandisp As aipmandisp        


		Public Property idaipusudisp() As Decimal
			Get
				Return Me.p_idaipusudisp
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipusudisp = Value
			End Set
		End Property

		Public Property idsegmanusu() As Decimal
			Get
				Return Me.p_idsegmanusu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusu = Value
			End Set
		End Property

		Public Property idaipmandisp() As Decimal
			Get
				Return Me.p_idaipmandisp
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmandisp = Value
			End Set
		End Property

		Public Property idseglogreg() As Decimal
			Get
				Return Me.p_idseglogreg
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idseglogreg = Value
			End Set
		End Property

        'relaciones
        Public Property aipmandisp() As aipmandisp
            Get
                Return Me.p_aipmandisp
            End Get
            Set(ByVal Value As aipmandisp)
                Me.p_aipmandisp = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipusudisppaglist

	Private p_pagaipusudisp As paginacion
	Private p_aipusudisp As aipusudisp

	Public Property pagaipusudisp() As paginacion
	Get
	Return Me.p_pagaipusudisp
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipusudisp = Value
	End Set
	End Property

	Public Property aipusudisp() As aipusudisp
	Get
	Return Me.p_aipusudisp
	End Get
	Set(ByVal Value As aipusudisp)
	Me.p_aipusudisp = Value
	End Set
	End Property
	End Class
	
	Public Class respaipusudisppaglist

	Private p_pagaipusudisp As paginacion
	Private p_lista_aipusudisp As  List(Of aipusudisp)

	Public Property pagaipusudisp() As paginacion
	Get
	Return Me.p_pagaipusudisp
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipusudisp = Value
	End Set
	End Property

	Public Property lista_aipusudisp() As List(Of aipusudisp)
	Get
	Return Me.p_lista_aipusudisp
	End Get
	Set(ByVal Value As List(Of aipusudisp))
	Me.p_lista_aipusudisp = Value
	End Set
	End Property
	End Class

End Namespace
