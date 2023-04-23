USE company;

-- Заполнение таблиц данными об отделах, сотрудниках и руководителях

INSERT INTO department (name) VALUE ('Frontend');
INSERT INTO department (name) VALUE ('Backend');
INSERT INTO department (name) VALUE ('Game Design');
INSERT INTO department (name) VALUE ('Desktop program');
INSERT INTO employee (department_id, name, salary) VALUE ('1','Ваня','60000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('1','1','Миша','250000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('1','2','Маша','100000');
INSERT INTO employee (department_id, name, salary) VALUE ('2','Дима','150000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('2','4','Ваня','130000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('2','5','Кирилл','90000');
INSERT INTO employee (department_id, name, salary) VALUE ('3','Тимофей','90000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('3','6','Иван','90000');
INSERT INTO employee (department_id, name, salary) VALUE ('4','Лена','90000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('4','8','Лёша','90000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('4','9','Ева','90000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('4','10','Андрей','90000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('4','10','Роман','100000');
INSERT INTO employee (department_id, chief_id, name, salary) VALUE ('4','10','Рамзес','190000');

