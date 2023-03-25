

CREATE TABLE tb02_professores_isolated(	
   `tb02_prof_matricula` INT(11) NOT NULL,
	`tb02_prof_nome` VARCHAR(50) NULL DEFAULT NULL,
	`tb02_prof_componente` VARCHAR(50) NULL DEFAULT NULL,
	PRIMARY KEY (`tb02_prof_matricula`)
	)