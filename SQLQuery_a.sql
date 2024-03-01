/*Write a query which returns the correct number of shifts for Joseph White along with the role, location, start and end.*/

select s.role, count(location) over(partition by location) as no_of_shifts, s.[location], s.[start],s.[end] from People as p 
Inner Join Shifts as s on (s.person_id=p.id)
where p.name='Joseph White'

/*Write a query to return the role with the most shifts and the number of shifts it has.*/
select top(1)  [role], count(role) as no_of_shifts from Shifts 
group by [role]
order by count(role) DESC

/*Write a query to work out the number of total unique locations.*/
select count(*) as no_of_unique_locations 
from ((select distinct [location] from Shifts)) as loc

/*Write a query to list shifts for active people where the shift starts between 15th November 2023 + 19th November 2023.*/

select p.name, s.role,  s.[location], s.[start],s.[end] from People as p 
Inner Join Shifts as s on (s.person_id=p.id)
where p.active=1 and s.[start] BETWEEN '2023/11/15' and '2023/11/19'

