Select unique(hpn.pack_id),
			 hpn.pack_name,
			 hpn.no_of_sizes,
			 hpn.no_of_units
From hir_pack_names     hpn,
		 hir_pack_makeup    hpm,
		 war_hir_pack_match whpm,
		 ref_product        p
Where whpm.pack_id = hpn.pack_id
And whpm.pack_id = hpm.pack_id
And whpm.product_number = p.product_number
And p.dss_department_code Like @0 || '%'
And p.dss_subdepartment_code Like @1 || '%'
And p.section_code Like @2 || '%'
And p.dss_range_code Like @3 || '%'
And p.dss_subrange_code Like @4 || '%'
Order By hpn.pack_id Asc