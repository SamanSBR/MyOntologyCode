from core.being import Being
from core.distinction import Distinction
from core.relation import Relation
from core.time import TimeOrder
from core.interpretation import Interpretation
from core.consistency import Consistency

x = Being()
y = Being()

print(Distinction(x, y).holds())

r = Relation(x, y, "appears-after")
print(r)

t = TimeOrder()
t.mark("question")
t.mark("answer")

print(t.before("question", "answer"))

i = Interpretation("world", "something exists")
print(i)

print(Consistency.contradicts("truth", "not truth"))
