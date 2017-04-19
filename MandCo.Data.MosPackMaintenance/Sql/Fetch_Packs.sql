Select unique(pNames.pack_id),
		 	  pNames.pack_name,
			  pNames.no_of_sizes,
			  pNames.no_of_units
From	 hir_pack_names     pNames,
		 hir_pack_makeup    pMakeup,
		 war_hir_pack_match pMatch,
		 ref_product        product
Where	 pMatch.pack_id = pNames.pack_id
And		 pMatch.pack_id = pMakeup.pack_id
And		 pMatch.product_number = product.product_number
And		 product.dss_department_code Like @0 || '%'
And		 product.dss_subdepartment_code Like @1 || '%'
And		 product.section_code Like @2 || '%'
And		 product.dss_range_code Like @3 || '%'
And		 product.dss_subrange_code Like @4 || '%'
Order By pNames.pack_id Asc