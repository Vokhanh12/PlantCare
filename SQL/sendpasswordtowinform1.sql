SELECT ncc.ID,ncc.UserName,ncc.UserPassword,mcc.MaQL,mcc.TenQL,mcc.TAI_KHOANG,mcc.NGAY_DANG_NHAP FROM APPLICATION_USER ncc,DATA_APPLICATION_FOR_MANAGER mcc WHERE mcc.UserName='khanh1803' and ncc.Username='khanh1803'