from pyx import *

from pyx.metapost.path import beginknot, endknot, smoothknot, tensioncurve

c = canvas.canvas()

d_letter = [path.line(1, 1, 1, 6) ,path.curve(1,1,5,1,5,6,1,6)]

o_letter = [path.curve(7,1,4,1,4,6,7,6), path.curve(7,1,10,1,10,6,7,6)]

m_letter = [path.line(11,1,11,6), path.line(11,6,13,1),path.line(13,1,15,6),path.line(15,1,15,6)]

def draw_i(x1,y1,x2,y2):
    return [path.line(x1,y1,x2,y2)]

n_letter = [path.line(19,1,19,6),path.line(19,6,21,1),path.line(21,1,21,6)]

k_letter = [path.line(25,1,25,6),path.line(25,3,27,6),path.line(25,3,27,1)]
def plot_letter(letter):
    res = [c.stroke(x,[style.linewidth.THick]) for x in letter]
    return res

plot_letter(d_letter)
plot_letter(o_letter)
plot_letter(m_letter)
plot_letter(draw_i(17,1,17,6))
plot_letter(n_letter)
plot_letter(draw_i(23,1,23,6))
plot_letter(k_letter)

c.writeEPSfile("metapost")
c.writePDFfile("metapost")
