Select unique(packMatch.Pack_Code) "Pack_Code"
From     war_hir_pack_match packMatch
Where	 packMatch.Pack_Id = @0
Order by packMatch.Pack_Code Asc