INSERT INTO variety_university(vName) VALUES('ΤΕΙ');
INSERT INTO variety_university(vName) VALUES('ΑΕΙ');
INSERT INTO variety_university(vName) VALUES('ΣΤΡΑΤΙΩΤΙΚΕΣ ΣΧΟΛΕΣ');
INSERT INTO variety_university(vName) VALUES('ΑΣΠΑΙΤΕ');

INSERT INTO university(unName,vID) VALUES('Οικονομικό Πανεπιστήμιο Αθηνων',2);
INSERT INTO university(unName,vID) VALUES('Αριστοτέλειο Πανεπιστήμιο Θεσσαλονίκης',2);
INSERT INTO university(unName,vID) VALUES('ΤΕΙ Στερεάς ελλάδας',1);


INSERT INTO school_sector(sectName,unID) VALUES('σχολή οικονομικών επιστημών',1);
INSERT INTO school_sector(sectName,unID) VALUES('σχολή διοικησης επιχηρήσεων',1);
INSERT INTO school_sector(sectName,unID) VALUES('σχολή επιστημών και τεχνολογίας της πληροφορίας',1);
INSERT INTO school_sector(sectName,unID) VALUES('σχολή επαγγελμάτων υγείας και πρόνοιας',3);


INSERT INTO department(dName,dCode,durationStudy,dLink,dNote,dCity,sectID) VALUES('τμήμα πληροφορική',333,4,'http://www.cs.aueb.gr','ελλειπης πληροφορίες','Αθήνα',3); /*15632 base */
INSERT INTO department(dName,dCode,durationStudy,dLink,dNote,dCity,sectID) VALUES('φυσικοθεραπεία',615,4,'http://www.psf.org.gr','ελλειπης πληροφορίες','Αθήνα',4); /*17236 base */


INSERT INTO scientific_field(scienName) VALUES('1ο επιστημονικό πεδίο');
INSERT INTO scientific_field(scienName) VALUES('2ο επιστημονικό πεδίο');
INSERT INTO scientific_field(scienName) VALUES('3ο επιστημονικό πεδίο');
INSERT INTO scientific_field(scienName) VALUES('4ο επιστημονικό πεδίο');

INSERT INTO department_scientific_field(dID,scienID) VALUES(1,2);
INSERT INTO department_scientific_field(dID,scienID) VALUES(1,4);

INSERT INTO extra_courses(extraName) VALUES('τίποτα');
INSERT INTO extra_courses(extraName) VALUES('ελεύθερο σχέδιο');
INSERT INTO extra_courses(extraName) VALUES('γραμμικό σχέδιο');
INSERT INTO extra_courses(extraName) VALUES('δρόμος 100μ,σε 17λεπτα');
INSERT INTO extra_courses(extraName) VALUES('άλμα σε ύψος με φόρα,σε 1,00μέτρα');

INSERT INTO department_extra_courses(dID,extraID) VALUES(1,1);

INSERT INTO direction(directionName,dID) VALUES('θεωριτική πληροφορική',1);
INSERT INTO direction(directionName,dID) VALUES('Συστήματα και Δικτυα υπολογιστών',1);
INSERT INTO direction(directionName,dID) VALUES('πληροφοριακά συστήμτα και ασφάλεια',1);
INSERT INTO direction(directionName,dID) VALUES('Βάσεις Δεδομένων και Διαχείρηση Γνώσης',1);
INSERT INTO direction(directionName,dID) VALUES('Επιχειρισιακή Ερευνα και οικονομικά πληροφορικής',1);
INSERT INTO direction(directionName,dID) VALUES('υπολογοστικά μαθηματικά και επιστημονική υπολογισμοι',1);

INSERT INTO postgraduate(gradName,gradNote,unID) VALUES('επιστήμη των υπολογιστών','καμία περιγραφή για επιστήμη των υπολογιστών',1);
INSERT INTO postgraduate(gradName,gradNote,unID) VALUES('πληροφοριακά συστήμτα','καμία περιγραφή για πληροφοριακά συστήματα',1);

INSERT INTO department_postgraduate(dID,gradID) VALUES(1,1);
INSERT INTO department_postgraduate(dID,gradID) VALUES(1,2);

INSERT INTO profession_job(jobName,jobNote) VALUES('προγραμματιστής','γράφει κώδικα σε μια γλώσσα προγραμματισμού,προκειμένου να δημιουργήσει κάποιο πρόγραμμα');
INSERT INTO profession_job(jobName,jobNote) VALUES('αναλυτής','αναλύει το πρόβλημα και φτίαχνει ένα σχήμα μέσω του οποίου θα κινηθεί ο προγραμματιστής');

INSERT INTO department_profession_job(dID,jobID) VALUES(1,1);
INSERT INTO department_profession_job(dID,jobID) VALUES(1,2);

INSERT INTO professional_rightsNote(rName) VALUES('Εκτός από το διορισμό στο Δημόσιο στον κλάδο ΠΕ Πληροφορικής (δείτε την προηγούμενη ερώτηση), σύμφωνα με το άρθρο 2 του Προεδρικού Διατάγματος Νο. 44 που έχει δημοσιευτεί στην Εφημερίδα της Κυβερνήσεως ΦΕΚ 58, 8/4/2009, οι πτυχιούχοι των τμημάτων πληροφορικής διαθέτουν γνωστικό υπόβαθρο συναφές με το υλικό και το λογισμικό για τη συγκέντρωση, ταξινόμηση, επεξεργασία και μετάδοση της πληροφορίας, και έχουν την ικανότητα να ασχοληθούν ενδεικτικά με δραστηριότητες όπως μελέτη, σχεδίαση, ανάλυση, υλοποίηση, εγκατάσταση, επίβλεψη, λειτουργία, αξιολόγηση, διενέργεια πραγματογνωμοσύνης και πιστοποίηση στους επιστημονικούς τομείς');

INSERT INTO department_professional_rightsNote(dID,rID) VALUES(1,1);

INSERT INTO indicative_employment_places(plName) VALUES('Τμηματα Πληροφοριακών Συστήματων');
INSERT INTO indicative_employment_places(plName) VALUES('Εταιρείες Συμβούλων Επιχειρίσεων');

INSERT INTO department_indicative_employment_places(dID,plID) VALUES(1,1);
INSERT INTO department_indicative_employment_places(dID,plID) VALUES(1,2);

INSERT INTO base(bNum,bYear,dID) VALUES(15632,2017,1);
INSERT INTO base(bNum,bYear,dID) VALUES(15700,2016,1);
INSERT INTO base(bNum,bYear,dID) VALUES(17236,2017,2);
INSERT INTO base(bNum,bYear,dID) VALUES(16800,2016,2);




