<template>
  <v-card>
    <v-card-title>
      User
      <v-spacer />
      <v-text-field
        v-model="search"
        append-icon="search"
        label="Search"
        single-line
        hide-details
      />
    </v-card-title>
    <v-data-table
      :headers="headers"
      :items="users"
      :search="search"
      class="elevation-1"
    >
      <template v-slot:items="props">
        <td class="text-xs-right">
          {{ props.item.id }}
        </td>
        <td>
          {{ props.item.username }}
        </td>
        <td>
          {{ props.item.firstName }}
        </td>
        <td>
          {{ props.item.lastName }}
        </td>
        <td>{{ props.item.title }}</td>
        <td class="justify-center layout px-0">
          <v-icon
            small
            class="mr-2"
            @click="editItem(props.item)"
          >
            edit
          </v-icon>
          <v-icon
            small
            @click="deleteItem(props.item)"
          >
            delete
          </v-icon>
        </td>
      </template>
    </v-data-table>
  </v-card>
</template>
<script>
import UsersService from '@/services/UsersService';

const usersService = new UsersService();
export default {
  data() {
    return {
      search: '',
      loading: true,
      headers: [
        {
          text: 'Id',
          align: 'right',
          sortable: true,
          value: 'id',
        },
        { text: 'Username', value: 'Username' },
        { text: 'First Name', value: 'firstName' },
        { text: 'Last Name', value: 'lastName' },
        { text: 'Title', value: 'title' },
        { text: 'Actions', value: 'name', sortable: false },
      ],
      users: [],
    };
  },
  mounted() {
    this.load();
  },
  methods: {
    load() {
      this.loading = true;
      usersService.getAll().then((data) => {
        this.users = data;
        this.loading = false;
      });
    },
    editItem(item) {
      console.log(item);
      this.$router.push({ name: 'UpdateUser', params: { id: item.id.toString() } });
    },
    deleteItem(item) {
      this.$root.$confirm('Delete', 'Are you sure?', { color: 'red' }).then((confirm) => {
        if (confirm) {
          usersService.delete(item.id).then(() => this.load());
        }
      });
    },
  },
};
</script>
