USE company;
-- 1. Запрос на вывод сотрудника с максимальной заработной платой
/* SELECT * FROM employee
WHERE salary = (SELECT MAX(salary) FROM employee) */

-- 2. Запрос на вычисление глубины дерева по руководителям
/*WITH RECURSIVE tree(id, chief_id, depth) AS (
  SELECT id, chief_id, 0
  FROM employee
  WHERE chief_id IS NULL
  UNION ALL
  SELECT employee.id, employee.chief_id, tree.depth + 1
  FROM employee
  JOIN tree ON employee.chief_id = tree.id
)
SELECT MAX(depth) FROM tree;*/

-- 3. Запрос для нахождения отдела с максимальной суммарной зарплатой сотрудников
/*SELECT department_id, (SUM(salary)) sum_salary 
FROM employee
GROUP BY department_id
ORDER BY sum_salary DESC
LIMIT 1;*/

-- 4. Запрос, ищущий сотрудника, чье имя начинается на "Р" и заканчивается на "н"
/*SELECT name FROM employee
WHERE name LIKE "Р%н";*/