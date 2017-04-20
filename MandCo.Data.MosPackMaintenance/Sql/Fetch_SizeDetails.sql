Select unique(pMakeup.Size_Code) "Size_Code",
       refSize.Size_Description "Size_Description"
From   hir_pack_makeup pMakeup,
       ref_size        refSize
Where  pMakeup.Pack_Id = @0
And    pMakeup.Size_Code = refSize.Size_Code