from pyx import *
import math


points = [[0.01 * x * math.cos(6 * 0.01 * x), 0.01 * x * math.sin(6 * 0.01 * x), 0.01 * x] for x in range(0,720) ]


values = graph.data.points(points,title="points",x=1, y=2, z=3)

g = graph.graphxyz(size=5,x=graph.axis.linear(title="x"),
                  y=graph.axis.linear(title="y"),
                  z=graph.axis.linear(title="z")) 

g.plot(values, [graph.style.line()])
g.dodata()
g.writePDFfile("spiral")
