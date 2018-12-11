# Read data from a csv\
import pandas
import matplotlib.pyplot as plt
from mpl_toolkits.mplot3d import axes3d, Axes3D
df = pandas.read_csv('./Lunar_topo_dataset.csv')
print(type(df['topography'].values))
fig = plt.figure()
ax = Axes3D(fig)
ax.plot_trisurf(df['Pt_Longitude'].values, df['Pt_Latitude'].values, df['topography'].values,
                cmap='viridis', edgecolor='none')
ax.set_title('surface')
fig.savefig('./lunar_topo_3d')

